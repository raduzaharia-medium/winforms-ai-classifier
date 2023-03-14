namespace Clasificare
{
    partial class ApplicationGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPopulation = new System.Windows.Forms.GroupBox();
            this.lblMaximumHeight = new System.Windows.Forms.Label();
            this.numMaximumHeight = new System.Windows.Forms.NumericUpDown();
            this.lblMinimalHeight = new System.Windows.Forms.Label();
            this.numMinimalHeight = new System.Windows.Forms.NumericUpDown();
            this.lblPopulationSize = new System.Windows.Forms.Label();
            this.numPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.grpEvolution = new System.Windows.Forms.GroupBox();
            this.lblCopiedIndividuals = new System.Windows.Forms.Label();
            this.numCopiedIndividuals = new System.Windows.Forms.NumericUpDown();
            this.lblSelectionProbability = new System.Windows.Forms.Label();
            this.numSelectionProbability = new System.Windows.Forms.NumericUpDown();
            this.lblMutationProbability = new System.Windows.Forms.Label();
            this.numMutationProbability = new System.Windows.Forms.NumericUpDown();
            this.grpEvolutionControl = new System.Windows.Forms.GroupBox();
            this.btnEvolve = new System.Windows.Forms.Button();
            this.lblStepCount = new System.Windows.Forms.Label();
            this.numStepCount = new System.Windows.Forms.NumericUpDown();
            this.tbcViews = new System.Windows.Forms.TabControl();
            this.tabPopulationView = new System.Windows.Forms.TabPage();
            this.webPopulationView = new System.Windows.Forms.WebBrowser();
            this.grpClassifier = new System.Windows.Forms.GroupBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lblVariables = new System.Windows.Forms.Label();
            this.txtVariables = new System.Windows.Forms.TextBox();
            this.grpPopulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximumHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimalHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSize)).BeginInit();
            this.grpEvolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCopiedIndividuals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectionProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutationProbability)).BeginInit();
            this.grpEvolutionControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStepCount)).BeginInit();
            this.tbcViews.SuspendLayout();
            this.tabPopulationView.SuspendLayout();
            this.grpClassifier.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPopulation
            // 
            this.grpPopulation.Controls.Add(this.lblMaximumHeight);
            this.grpPopulation.Controls.Add(this.numMaximumHeight);
            this.grpPopulation.Controls.Add(this.lblMinimalHeight);
            this.grpPopulation.Controls.Add(this.numMinimalHeight);
            this.grpPopulation.Controls.Add(this.lblPopulationSize);
            this.grpPopulation.Controls.Add(this.numPopulationSize);
            this.grpPopulation.Location = new System.Drawing.Point(12, 12);
            this.grpPopulation.Name = "grpPopulation";
            this.grpPopulation.Size = new System.Drawing.Size(161, 100);
            this.grpPopulation.TabIndex = 0;
            this.grpPopulation.TabStop = false;
            this.grpPopulation.Text = "Populatie";
            // 
            // lblMaximumHeight
            // 
            this.lblMaximumHeight.AutoSize = true;
            this.lblMaximumHeight.Location = new System.Drawing.Point(6, 73);
            this.lblMaximumHeight.Name = "lblMaximumHeight";
            this.lblMaximumHeight.Size = new System.Drawing.Size(81, 13);
            this.lblMaximumHeight.TabIndex = 1;
            this.lblMaximumHeight.Text = "Inaltime maxima";
            // 
            // numMaximumHeight
            // 
            this.numMaximumHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numMaximumHeight.Location = new System.Drawing.Point(90, 71);
            this.numMaximumHeight.Name = "numMaximumHeight";
            this.numMaximumHeight.Size = new System.Drawing.Size(65, 20);
            this.numMaximumHeight.TabIndex = 1;
            this.numMaximumHeight.ValueChanged += new System.EventHandler(this.UpdateConfiguration);
            // 
            // lblMinimalHeight
            // 
            this.lblMinimalHeight.AutoSize = true;
            this.lblMinimalHeight.Location = new System.Drawing.Point(6, 47);
            this.lblMinimalHeight.Name = "lblMinimalHeight";
            this.lblMinimalHeight.Size = new System.Drawing.Size(78, 13);
            this.lblMinimalHeight.TabIndex = 1;
            this.lblMinimalHeight.Text = "Inaltime minima";
            // 
            // numMinimalHeight
            // 
            this.numMinimalHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numMinimalHeight.Location = new System.Drawing.Point(90, 45);
            this.numMinimalHeight.Name = "numMinimalHeight";
            this.numMinimalHeight.Size = new System.Drawing.Size(65, 20);
            this.numMinimalHeight.TabIndex = 1;
            this.numMinimalHeight.ValueChanged += new System.EventHandler(this.UpdateConfiguration);
            // 
            // lblPopulationSize
            // 
            this.lblPopulationSize.AutoSize = true;
            this.lblPopulationSize.Location = new System.Drawing.Point(6, 21);
            this.lblPopulationSize.Name = "lblPopulationSize";
            this.lblPopulationSize.Size = new System.Drawing.Size(72, 13);
            this.lblPopulationSize.TabIndex = 1;
            this.lblPopulationSize.Text = "Numar indivizi";
            // 
            // numPopulationSize
            // 
            this.numPopulationSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numPopulationSize.Location = new System.Drawing.Point(90, 19);
            this.numPopulationSize.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPopulationSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPopulationSize.Name = "numPopulationSize";
            this.numPopulationSize.Size = new System.Drawing.Size(65, 20);
            this.numPopulationSize.TabIndex = 1;
            this.numPopulationSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPopulationSize.ValueChanged += new System.EventHandler(this.UpdateConfiguration);
            // 
            // grpEvolution
            // 
            this.grpEvolution.Controls.Add(this.lblCopiedIndividuals);
            this.grpEvolution.Controls.Add(this.numCopiedIndividuals);
            this.grpEvolution.Controls.Add(this.lblSelectionProbability);
            this.grpEvolution.Controls.Add(this.numSelectionProbability);
            this.grpEvolution.Controls.Add(this.lblMutationProbability);
            this.grpEvolution.Controls.Add(this.numMutationProbability);
            this.grpEvolution.Location = new System.Drawing.Point(179, 12);
            this.grpEvolution.Name = "grpEvolution";
            this.grpEvolution.Size = new System.Drawing.Size(175, 100);
            this.grpEvolution.TabIndex = 1;
            this.grpEvolution.TabStop = false;
            this.grpEvolution.Text = "Evolutie";
            // 
            // lblCopiedIndividuals
            // 
            this.lblCopiedIndividuals.AutoSize = true;
            this.lblCopiedIndividuals.Location = new System.Drawing.Point(6, 73);
            this.lblCopiedIndividuals.Name = "lblCopiedIndividuals";
            this.lblCopiedIndividuals.Size = new System.Drawing.Size(73, 13);
            this.lblCopiedIndividuals.TabIndex = 5;
            this.lblCopiedIndividuals.Text = "Indivizi copiati";
            // 
            // numCopiedIndividuals
            // 
            this.numCopiedIndividuals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numCopiedIndividuals.Location = new System.Drawing.Point(116, 71);
            this.numCopiedIndividuals.Name = "numCopiedIndividuals";
            this.numCopiedIndividuals.Size = new System.Drawing.Size(53, 20);
            this.numCopiedIndividuals.TabIndex = 4;
            // 
            // lblSelectionProbability
            // 
            this.lblSelectionProbability.AutoSize = true;
            this.lblSelectionProbability.Location = new System.Drawing.Point(6, 47);
            this.lblSelectionProbability.Name = "lblSelectionProbability";
            this.lblSelectionProbability.Size = new System.Drawing.Size(104, 13);
            this.lblSelectionProbability.TabIndex = 3;
            this.lblSelectionProbability.Text = "Probabilitate selectie";
            // 
            // numSelectionProbability
            // 
            this.numSelectionProbability.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numSelectionProbability.DecimalPlaces = 1;
            this.numSelectionProbability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSelectionProbability.Location = new System.Drawing.Point(116, 45);
            this.numSelectionProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSelectionProbability.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSelectionProbability.Name = "numSelectionProbability";
            this.numSelectionProbability.Size = new System.Drawing.Size(53, 20);
            this.numSelectionProbability.TabIndex = 2;
            this.numSelectionProbability.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // lblMutationProbability
            // 
            this.lblMutationProbability.AutoSize = true;
            this.lblMutationProbability.Location = new System.Drawing.Point(6, 21);
            this.lblMutationProbability.Name = "lblMutationProbability";
            this.lblMutationProbability.Size = new System.Drawing.Size(102, 13);
            this.lblMutationProbability.TabIndex = 1;
            this.lblMutationProbability.Text = "Probabilitate mutatie";
            // 
            // numMutationProbability
            // 
            this.numMutationProbability.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numMutationProbability.DecimalPlaces = 1;
            this.numMutationProbability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMutationProbability.Location = new System.Drawing.Point(116, 19);
            this.numMutationProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMutationProbability.Name = "numMutationProbability";
            this.numMutationProbability.Size = new System.Drawing.Size(53, 20);
            this.numMutationProbability.TabIndex = 0;
            this.numMutationProbability.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // grpEvolutionControl
            // 
            this.grpEvolutionControl.Controls.Add(this.btnEvolve);
            this.grpEvolutionControl.Controls.Add(this.lblStepCount);
            this.grpEvolutionControl.Controls.Add(this.numStepCount);
            this.grpEvolutionControl.Location = new System.Drawing.Point(360, 12);
            this.grpEvolutionControl.Name = "grpEvolutionControl";
            this.grpEvolutionControl.Size = new System.Drawing.Size(130, 100);
            this.grpEvolutionControl.TabIndex = 2;
            this.grpEvolutionControl.TabStop = false;
            this.grpEvolutionControl.Text = "Control evolutie";
            // 
            // btnEvolve
            // 
            this.btnEvolve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEvolve.Location = new System.Drawing.Point(6, 45);
            this.btnEvolve.Name = "btnEvolve";
            this.btnEvolve.Size = new System.Drawing.Size(118, 23);
            this.btnEvolve.TabIndex = 2;
            this.btnEvolve.Text = "Evolueaza";
            this.btnEvolve.UseVisualStyleBackColor = true;
            this.btnEvolve.Click += new System.EventHandler(this.btnEvolve_Click);
            // 
            // lblStepCount
            // 
            this.lblStepCount.AutoSize = true;
            this.lblStepCount.Location = new System.Drawing.Point(6, 21);
            this.lblStepCount.Name = "lblStepCount";
            this.lblStepCount.Size = new System.Drawing.Size(60, 13);
            this.lblStepCount.TabIndex = 1;
            this.lblStepCount.Text = "Numar pasi";
            // 
            // numStepCount
            // 
            this.numStepCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numStepCount.Location = new System.Drawing.Point(72, 19);
            this.numStepCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStepCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStepCount.Name = "numStepCount";
            this.numStepCount.Size = new System.Drawing.Size(52, 20);
            this.numStepCount.TabIndex = 0;
            this.numStepCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbcViews
            // 
            this.tbcViews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcViews.Controls.Add(this.tabPopulationView);
            this.tbcViews.Location = new System.Drawing.Point(12, 120);
            this.tbcViews.Name = "tbcViews";
            this.tbcViews.SelectedIndex = 0;
            this.tbcViews.Size = new System.Drawing.Size(751, 375);
            this.tbcViews.TabIndex = 3;
            // 
            // tabPopulationView
            // 
            this.tabPopulationView.Controls.Add(this.webPopulationView);
            this.tabPopulationView.Location = new System.Drawing.Point(4, 22);
            this.tabPopulationView.Name = "tabPopulationView";
            this.tabPopulationView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPopulationView.Size = new System.Drawing.Size(743, 323);
            this.tabPopulationView.TabIndex = 0;
            this.tabPopulationView.Text = "Vizualizare populatie";
            this.tabPopulationView.UseVisualStyleBackColor = true;
            // 
            // webPopulationView
            // 
            this.webPopulationView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPopulationView.Location = new System.Drawing.Point(3, 3);
            this.webPopulationView.MinimumSize = new System.Drawing.Size(20, 20);
            this.webPopulationView.Name = "webPopulationView";
            this.webPopulationView.Size = new System.Drawing.Size(737, 317);
            this.webPopulationView.TabIndex = 0;
            // 
            // grpClassifier
            // 
            this.grpClassifier.Controls.Add(this.btnAnalyze);
            this.grpClassifier.Controls.Add(this.lblVariables);
            this.grpClassifier.Controls.Add(this.txtVariables);
            this.grpClassifier.Location = new System.Drawing.Point(496, 12);
            this.grpClassifier.Name = "grpClassifier";
            this.grpClassifier.Size = new System.Drawing.Size(230, 100);
            this.grpClassifier.TabIndex = 4;
            this.grpClassifier.TabStop = false;
            this.grpClassifier.Text = "Clasificare";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyze.Location = new System.Drawing.Point(113, 45);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(111, 23);
            this.btnAnalyze.TabIndex = 2;
            this.btnAnalyze.Text = "Clasifica";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lblVariables
            // 
            this.lblVariables.AutoSize = true;
            this.lblVariables.Location = new System.Drawing.Point(6, 22);
            this.lblVariables.Name = "lblVariables";
            this.lblVariables.Size = new System.Drawing.Size(47, 13);
            this.lblVariables.TabIndex = 1;
            this.lblVariables.Text = "Variabile";
            // 
            // txtVariables
            // 
            this.txtVariables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVariables.Location = new System.Drawing.Point(59, 19);
            this.txtVariables.Name = "txtVariables";
            this.txtVariables.Size = new System.Drawing.Size(165, 20);
            this.txtVariables.TabIndex = 0;
            // 
            // ApplicationGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 504);
            this.Controls.Add(this.grpClassifier);
            this.Controls.Add(this.tbcViews);
            this.Controls.Add(this.grpEvolutionControl);
            this.Controls.Add(this.grpEvolution);
            this.Controls.Add(this.grpPopulation);
            this.Name = "ApplicationGui";
            this.Text = "Classifier";
            this.grpPopulation.ResumeLayout(false);
            this.grpPopulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximumHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimalHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSize)).EndInit();
            this.grpEvolution.ResumeLayout(false);
            this.grpEvolution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCopiedIndividuals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectionProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutationProbability)).EndInit();
            this.grpEvolutionControl.ResumeLayout(false);
            this.grpEvolutionControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStepCount)).EndInit();
            this.tbcViews.ResumeLayout(false);
            this.tabPopulationView.ResumeLayout(false);
            this.grpClassifier.ResumeLayout(false);
            this.grpClassifier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPopulation;
        private System.Windows.Forms.Label lblMaximumHeight;
        private System.Windows.Forms.NumericUpDown numMaximumHeight;
        private System.Windows.Forms.Label lblMinimalHeight;
        private System.Windows.Forms.NumericUpDown numMinimalHeight;
        private System.Windows.Forms.Label lblPopulationSize;
        private System.Windows.Forms.NumericUpDown numPopulationSize;
        private System.Windows.Forms.GroupBox grpEvolution;
        private System.Windows.Forms.Label lblSelectionProbability;
        private System.Windows.Forms.NumericUpDown numSelectionProbability;
        private System.Windows.Forms.Label lblMutationProbability;
        private System.Windows.Forms.NumericUpDown numMutationProbability;
        private System.Windows.Forms.Label lblCopiedIndividuals;
        private System.Windows.Forms.NumericUpDown numCopiedIndividuals;
        private System.Windows.Forms.GroupBox grpEvolutionControl;
        private System.Windows.Forms.Label lblStepCount;
        private System.Windows.Forms.NumericUpDown numStepCount;
        private System.Windows.Forms.Button btnEvolve;
        private System.Windows.Forms.TabControl tbcViews;
        private System.Windows.Forms.TabPage tabPopulationView;
        private System.Windows.Forms.WebBrowser webPopulationView;
        private System.Windows.Forms.GroupBox grpClassifier;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label lblVariables;
        private System.Windows.Forms.TextBox txtVariables;
    }
}