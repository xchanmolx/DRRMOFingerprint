using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DRRMOFingerprintApp.Model;

namespace DRRMOFingerprintApp
{
    public partial class Verification : CaptureForm
    {
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verifier;

        readonly DataAccess db = new DataAccess();
        List<PersonTest> people = new List<PersonTest>();

        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Fingerprint Verification";
            Verifier = new DPFP.Verification.Verification();    // Create a fingerprint template
            UpdateStatus(0);
        }

        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Process the sample and create a feature set for the verification purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                DPFP.Template template = new DPFP.Template();
                Stream stream;
                
                people = db.GetPeople();

                foreach (var person in people)
                {
                    stream = new MemoryStream(person.Fingerprint);
                    template = new DPFP.Template(stream);

                    Verifier.Verify(features, template, ref result);
                    UpdateStatus(result.FARAchieved);
                    if (result.Verified)
                    {
                        MakeReport("The fingerprint was VERIFIED. " + person.FullName);
                        break;
                    }
                }
            }
        }

        public Verification()
        {
            people = db.GetPeople();
            InitializeComponent();
        }
    }
}
