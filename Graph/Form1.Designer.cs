namespace Graph
{
    partial class Form1
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
            label1 = new Label();
            txtNodeName = new TextBox();
            label2 = new Label();
            txtFromNode = new TextBox();
            label3 = new Label();
            txtToNode = new TextBox();
            label4 = new Label();
            txtWeight = new TextBox();
            btnAddNode = new Button();
            btnAddEdge = new Button();
            dgvAdjacencyMatrix = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAdjacencyMatrix).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(110, 18);
            label1.TabIndex = 0;
            label1.Text = "Node Name";
            // 
            // txtNodeName
            // 
            txtNodeName.Font = new Font("Yu Gothic", 9.75F);
            txtNodeName.Location = new Point(152, 34);
            txtNodeName.Name = "txtNodeName";
            txtNodeName.Size = new Size(126, 28);
            txtNodeName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.Location = new Point(41, 196);
            label2.Name = "label2";
            label2.Size = new Size(104, 18);
            label2.TabIndex = 2;
            label2.Text = "From Node";
            // 
            // txtFromNode
            // 
            txtFromNode.Font = new Font("Yu Gothic", 9.75F);
            txtFromNode.Location = new Point(151, 186);
            txtFromNode.Name = "txtFromNode";
            txtFromNode.Size = new Size(126, 28);
            txtFromNode.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.Location = new Point(57, 241);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 4;
            label3.Text = "To Node";
            // 
            // txtToNode
            // 
            txtToNode.Font = new Font("Yu Gothic", 9.75F);
            txtToNode.Location = new Point(151, 234);
            txtToNode.Name = "txtToNode";
            txtToNode.Size = new Size(126, 28);
            txtToNode.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.Location = new Point(31, 279);
            label4.Name = "label4";
            label4.Size = new Size(119, 18);
            label4.TabIndex = 6;
            label4.Text = "Edge Weight";
            // 
            // txtWeight
            // 
            txtWeight.Font = new Font("Yu Gothic", 9.75F);
            txtWeight.Location = new Point(151, 277);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(126, 28);
            txtWeight.TabIndex = 7;
            // 
            // btnAddNode
            // 
            btnAddNode.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNode.Location = new Point(105, 93);
            btnAddNode.Name = "btnAddNode";
            btnAddNode.Size = new Size(98, 34);
            btnAddNode.TabIndex = 8;
            btnAddNode.Text = "Add Node";
            btnAddNode.UseVisualStyleBackColor = true;
            btnAddNode.Click += btnAddNode_Click;
            // 
            // btnAddEdge
            // 
            btnAddEdge.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEdge.Location = new Point(105, 311);
            btnAddEdge.Name = "btnAddEdge";
            btnAddEdge.Size = new Size(98, 34);
            btnAddEdge.TabIndex = 9;
            btnAddEdge.Text = "Add Edge";
            btnAddEdge.UseVisualStyleBackColor = true;
            btnAddEdge.Click += btnAddEdge_Click;
            // 
            // dgvAdjacencyMatrix
            // 
            dgvAdjacencyMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdjacencyMatrix.Location = new Point(329, 12);
            dgvAdjacencyMatrix.Name = "dgvAdjacencyMatrix";
            dgvAdjacencyMatrix.Size = new Size(458, 333);
            dgvAdjacencyMatrix.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 377);
            Controls.Add(txtNodeName);
            Controls.Add(txtFromNode);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnAddNode);
            Controls.Add(btnAddEdge);
            Controls.Add(dgvAdjacencyMatrix);
            Controls.Add(txtToNode);
            Controls.Add(txtWeight);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAdjacencyMatrix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNodeName;
        private Label label2;
        private TextBox txtFromNode;
        private Label label3;
        private TextBox txtToNode;
        private Label label4;
        private TextBox txtWeight;
        private Button btnAddNode;
        private Button btnAddEdge;
        private DataGridView dgvAdjacencyMatrix;
    }
}
