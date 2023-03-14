using System;
using System.Windows.Forms;
using System.IO;

namespace Clasificare
{
    public partial class ApplicationGui : Form
    {
        private Population population;
        private int generationCount;

        public ApplicationGui()
        {
            InitializeComponent();
            UpdateConfiguration(this, null);
        }

        private void UpdateConfiguration(object sender, EventArgs args)
        {
            generationCount = 0;
            population = new Population((int)numPopulationSize.Value, (int)numMinimalHeight.Value, (int)numMaximumHeight.Value);
            RandomGenerator.MaximumHeight = (int)numMaximumHeight.Value;

            UpdateOutput();
        }
        private void UpdateOutput()
        {
            var writer = new StringWriter();

            writer.WriteLine("<html>");
            writer.WriteLine("  <body style='font-family: Calibri; font-size: 11pt'>");
            writer.WriteLine("      Generation: " + generationCount + "<br/><br/>");
            writer.WriteLine("      Tree height: " + population.BestIndividual.MathExpression.Height.ToString() + "<br/>");
            writer.WriteLine("      Used variables: " + population.BestIndividual.MathExpression.Variables.Length.ToString() + "<br/>");
            writer.WriteLine("      Fitness: " + population.BestIndividual.Fitness.ToString() + "<br/><br/>");
            writer.WriteLine(population.BestIndividual.MathExpression.ToString());
            writer.WriteLine("  </body>");
            writer.WriteLine("</html>");

            webPopulationView.DocumentText = writer.ToString();
        }

        private void btnEvolve_Click(object sender, EventArgs e)
        {
            generationCount += (int)numStepCount.Value;
            for (int i = 0; i < (int)numStepCount.Value; i++) population = population.NextGeneration();

            UpdateOutput();
        }
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            var components = txtVariables.Text.Split(',');
            var componentsDouble = Array.ConvertAll(components, double.Parse);
            var result = 1;// population.BestIndividual.Evaluate(componentsDouble);

            MessageBox.Show(result.ToString());
        }
    }
}