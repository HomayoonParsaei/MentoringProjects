namespace RegularPolygon
{
    partial class FormPolygon
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxPolygoneType = new ComboBox();
            labelPolygonType = new Label();
            labelPolygonPerimeter = new Label();
            lablePolygonArea = new Label();
            labelSideLength = new Label();
            textBoxSideLength = new TextBox();
            buttonCalculate = new Button();
            SuspendLayout();
            // 
            // comboBoxPolygoneType
            // 
            comboBoxPolygoneType.FormattingEnabled = true;
            comboBoxPolygoneType.Location = new Point(125, 12);
            comboBoxPolygoneType.Name = "comboBoxPolygoneType";
            comboBoxPolygoneType.Size = new Size(121, 23);
            comboBoxPolygoneType.TabIndex = 0;
            // 
            // labelPolygonType
            // 
            labelPolygonType.AutoSize = true;
            labelPolygonType.Location = new Point(12, 15);
            labelPolygonType.Name = "labelPolygonType";
            labelPolygonType.Size = new Size(84, 15);
            labelPolygonType.TabIndex = 2;
            labelPolygonType.Text = "Polygon Type :";
            // 
            // labelPolygonPerimeter
            // 
            labelPolygonPerimeter.AutoSize = true;
            labelPolygonPerimeter.Location = new Point(13, 148);
            labelPolygonPerimeter.Name = "labelPolygonPerimeter";
            labelPolygonPerimeter.Size = new Size(105, 15);
            labelPolygonPerimeter.TabIndex = 2;
            labelPolygonPerimeter.Text = "Polygon Perimeter";
            labelPolygonPerimeter.Visible = false;
            // 
            // lablePolygonArea
            // 
            lablePolygonArea.AutoSize = true;
            lablePolygonArea.Location = new Point(13, 183);
            lablePolygonArea.Name = "lablePolygonArea";
            lablePolygonArea.Size = new Size(78, 15);
            lablePolygonArea.TabIndex = 2;
            lablePolygonArea.Text = "Polygon Area";
            lablePolygonArea.Visible = false;
            // 
            // labelSideLength
            // 
            labelSideLength.AutoSize = true;
            labelSideLength.Location = new Point(12, 58);
            labelSideLength.Name = "labelSideLength";
            labelSideLength.Size = new Size(106, 15);
            labelSideLength.TabIndex = 3;
            labelSideLength.Text = "Side Length [cm]  :";
            // 
            // textBoxSideLength
            // 
            textBoxSideLength.Location = new Point(125, 55);
            textBoxSideLength.Name = "textBoxSideLength";
            textBoxSideLength.Size = new Size(121, 23);
            textBoxSideLength.TabIndex = 4;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(58, 96);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(144, 28);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // FormPolygon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(500, 234);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxSideLength);
            Controls.Add(labelSideLength);
            Controls.Add(lablePolygonArea);
            Controls.Add(labelPolygonPerimeter);
            Controls.Add(labelPolygonType);
            Controls.Add(comboBoxPolygoneType);
            Margin = new Padding(2);
            Name = "FormPolygon";
            Text = "Regular Polygon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPolygoneType;
        private Label labelPolygonType;
        private Label labelPolygonPerimeter;
        private Label lablePolygonArea;
        private Label labelSideLength;
        private TextBox textBoxSideLength;
        private Button buttonCalculate;
    }
}
