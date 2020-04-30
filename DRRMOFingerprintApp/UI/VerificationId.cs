using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DRRMOFingerprintApp.Model;

namespace DRRMOFingerprintApp.UI
{
    public partial class VerificationId : CaptureForm
    {
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verifier;

        readonly DataAccess db = new DataAccess();
        IEnumerable<Person> people;
        IEnumerable<Fingerprint> fingerprints;

        public VerificationId()
        {
            InitializeComponent();
        }

        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Fingerprint Verification";
            Verifier = new DPFP.Verification.Verification(); // Create a fingerprint template
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
                fingerprints = db.GetFingerprints();

                foreach (var fingerprint in fingerprints)
                {
                    stream = new MemoryStream(fingerprint.FingerprintPerson);
                    template = new DPFP.Template(stream);

                    Verifier.Verify(features, template, ref result);
                    UpdateStatus(result.FARAchieved);
                    if (result.Verified)
                    {
                        foreach (var person in people)
                        {
                            if (person.Id == fingerprint.PersonId)
                            {
                                try
                                {
                                    var verifiedPerson = new VerifiedPerson();

                                    string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                                    verifiedPerson.pctrBoxProfile.Image = Image.FromFile(paths + person.StringImage);
                                    verifiedPerson.lblFName.Text = person.FirstName;
                                    verifiedPerson.lblMName.Text = person.MiddleName;
                                    verifiedPerson.lblLName.Text = person.LastName;
                                    verifiedPerson.lblExName.Text = person.ExtensionName;

                                    verifiedPerson.ShowDialog();

                                    verifiedPerson.Dispose();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Error, fetch profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
