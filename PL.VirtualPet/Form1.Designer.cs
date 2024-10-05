namespace PL.VirtualPet
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
            dgvPet = new DataGridView();
            btnPetAdd = new Button();
            btnPetUpdate = new Button();
            btnPetDelete = new Button();
            lblName = new Label();
            lblType = new Label();
            txtName = new TextBox();
            txtType = new TextBox();
            lblSelectedPet = new Label();
            Pets = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvPet).BeginInit();
            Pets.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPet
            // 
            dgvPet.BackgroundColor = Color.MintCream;
            dgvPet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPet.Location = new Point(88, 109);
            dgvPet.Name = "dgvPet";
            dgvPet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPet.Size = new Size(345, 165);
            dgvPet.TabIndex = 0;
            dgvPet.CellClick += dgvPet_CellClick;
            // 
            // btnPetAdd
            // 
            btnPetAdd.Location = new Point(7, 21);
            btnPetAdd.Name = "btnPetAdd";
            btnPetAdd.Size = new Size(75, 23);
            btnPetAdd.TabIndex = 1;
            btnPetAdd.Text = "Add";
            btnPetAdd.UseVisualStyleBackColor = true;
            btnPetAdd.Click += btnPetAdd_Click;
            // 
            // btnPetUpdate
            // 
            btnPetUpdate.Location = new Point(7, 50);
            btnPetUpdate.Name = "btnPetUpdate";
            btnPetUpdate.Size = new Size(75, 23);
            btnPetUpdate.TabIndex = 2;
            btnPetUpdate.Text = "Update";
            btnPetUpdate.UseVisualStyleBackColor = true;
            btnPetUpdate.Click += btnPetUpdate_Click;
            // 
            // btnPetDelete
            // 
            btnPetDelete.Location = new Point(7, 79);
            btnPetDelete.Name = "btnPetDelete";
            btnPetDelete.Size = new Size(75, 23);
            btnPetDelete.TabIndex = 3;
            btnPetDelete.Text = "Delete";
            btnPetDelete.UseVisualStyleBackColor = true;
            btnPetDelete.Click += btnPetDelete_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(108, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Pet Name :";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(108, 50);
            lblType.Name = "lblType";
            lblType.Size = new Size(57, 15);
            lblType.TabIndex = 5;
            lblType.Text = "Pet Type :";
            // 
            // txtName
            // 
            txtName.Location = new Point(179, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 6;
            // 
            // txtType
            // 
            txtType.Location = new Point(179, 47);
            txtType.Name = "txtType";
            txtType.Size = new Size(100, 23);
            txtType.TabIndex = 7;
            // 
            // lblSelectedPet
            // 
            lblSelectedPet.AutoSize = true;
            lblSelectedPet.Location = new Point(88, 106);
            lblSelectedPet.Name = "lblSelectedPet";
            lblSelectedPet.Size = new Size(77, 15);
            lblSelectedPet.TabIndex = 8;
            lblSelectedPet.Text = "Selected Pet :";
            // 
            // Pets
            // 
            Pets.Controls.Add(lblType);
            Pets.Controls.Add(lblSelectedPet);
            Pets.Controls.Add(btnPetAdd);
            Pets.Controls.Add(txtType);
            Pets.Controls.Add(btnPetUpdate);
            Pets.Controls.Add(txtName);
            Pets.Controls.Add(btnPetDelete);
            Pets.Controls.Add(lblName);
            Pets.Location = new Point(439, 131);
            Pets.Name = "Pets";
            Pets.Size = new Size(286, 124);
            Pets.TabIndex = 9;
            Pets.TabStop = false;
            Pets.Text = "Pets";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.My_Animal_Report_Basic_Information_Presentation_Pastel_Illustrated;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Pets);
            Controls.Add(dgvPet);
            Name = "Form1";
            Text = "SayHiToYourPet";
            ((System.ComponentModel.ISupportInitialize)dgvPet).EndInit();
            Pets.ResumeLayout(false);
            Pets.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPet;
        private Button btnPetAdd;
        private Button btnPetUpdate;
        private Button btnPetDelete;
        private Label lblName;
        private Label lblType;
        private TextBox txtName;
        private TextBox txtType;
        private Label lblSelectedPet;
        private GroupBox Pets;
    }
}
