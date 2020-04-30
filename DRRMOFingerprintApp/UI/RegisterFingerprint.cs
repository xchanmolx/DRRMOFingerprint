using System;
using DPFP;

namespace DRRMOFingerprintApp.UI
{
    public partial class RegisterFingerprint : CaptureForm
    {
        public delegate void OnTemplateEventHandler(Template template);

        public event OnTemplateEventHandler OnTemplate;

        private DPFP.Processing.Enrollment Enroller;

        protected override void Init()
        {
            base.Init();
            base.Text = "Register Fingerprint";
            Enroller = new DPFP.Processing.Enrollment(); // Create an enrollment.
            UpdateStatus();
        }

        protected override void Process(Sample Sample)
        {
            base.Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            // Check quality of the sample and add to enroller if it's good.
            if (features != null) try
                {
                    MakeReport(String.Format("The fingerprint feature set was created {0}", Enroller.FeaturesNeeded));
                    Enroller.AddFeatures(features); // Add feature set to template.
                }
                finally
                {
                    UpdateStatus();

                    // Check if template has been created.
                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready: // report success and stop capturing
                            OnTemplate(Enroller.Template);
                            SetPrompt("Click close, and then click Fingerprint Verification.");
                            Stop();
                            break;

                        case DPFP.Processing.Enrollment.Status.Failed: // report failure and restart capturing
                            Enroller.Clear();
                            Stop();
                            UpdateStatus();
                            OnTemplate(null);
                            Start();
                            break;
                    }
                }
        }

        private void UpdateStatus()
        {
            // Show number of samples needed.
            SetStatus(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded));
        }

        public RegisterFingerprint()
        {
            InitializeComponent();
        }
    }
}
