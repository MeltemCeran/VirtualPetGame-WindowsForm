
using BLL.VirtualPet.Managers.Concrete;
using BLL.VirtualPet.Models;
using System.Xml.Linq;

namespace PL.VirtualPet
{
    public partial class Form1 : Form
    {
        PetModel selectedModel;
        PetManager petManager = new PetManager();

        public Form1()
        {
            InitializeComponent();
            ListAllPets();
        }
        public void ClearTextBox()
        {
            txtName.Clear();
            txtType.Clear();
        }

        public void ListAllPets()
        {
            dgvPet.DataSource = petManager.GetAll();
        }

        private void btnPetAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtType.Text))
            {
                MessageBox.Show("Please fill all the textboxes!");
                return;
            }
            PetModel petModel = new PetModel();
            petModel.Name = txtName.Text;
            petModel.Type = txtType.Text;

            petManager.Add(petModel);
            ListAllPets();
            ClearTextBox();
            MessageBox.Show("Your pet has been succesfully added");
        }

        private void btnPetUpdate_Click(object sender, EventArgs e)
        {
            if (selectedModel != null)
            {
                selectedModel.Name = txtName.Text;
                selectedModel.Type = txtType.Text;
                petManager.Update(selectedModel);
                ListAllPets();
                ClearTextBox();
                selectedModel = null;
                lblSelectedPet.Text = "Selected Product";
                MessageBox.Show("Your pet has been succesfully updated!");
            }
            else
                MessageBox.Show("Please select a product to update!");
        }

        private void btnPetDelete_Click(object sender, EventArgs e)
        {
            if (selectedModel != null)
            {
                petManager.Delete(selectedModel);
                ListAllPets();
                ClearTextBox();
                selectedModel = null;
                lblSelectedPet.Text = "Selected Product";
                MessageBox.Show("Your pet has been succesfully deleted!");
            }
            else
                MessageBox.Show("Please select a product to deleted!");
        }

        private void dgvPet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedModel = (PetModel)dgvPet.SelectedRows[0].DataBoundItem;
            lblSelectedPet.Text = selectedModel.Name;

            txtName.Text = selectedModel.Name;
            txtType.Text = selectedModel.Type;
        }
    }
}
