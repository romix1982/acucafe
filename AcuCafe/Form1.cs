using AcuCafeCore;
using AcuCafeCore.Addins;
using AcuCafeCore.Factories;
using System;

using System.Windows.Forms;

namespace AcuCafe
{
    public partial class Form1 : Form
    {
        IDrink drinkOrder;
        const bool IsCoffee = true;
        const bool IsTea = false;
   
        public Form1()
        {
            InitializeComponent();
            InitializeSystem();
        }

        /// <summary>
        /// inicialize Drinks combobox
        /// </summary>
        private void InitializeSystem()
        {
            cmbDrinks.DataSource = Enum.GetValues(typeof(AcuCafeEnum.EnumDrinks));
        }

        /// <summary>
        /// Process the order and show the result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            ProcessOrder();
            UpdateUI();
            CleanAddIns();
        }

        /// <summary>
        /// Update UI showing the barista instruction
        /// the order and the total amount
        /// </summary>
        private void UpdateUI()
        {
            lblBarista.Text = "Hey Barista, this is your next order: \n" + drinkOrder.Prepare();
            lblOrderInfo.Text = "This is your orden: " + drinkOrder.Prepare();
            lblTotalAmount.Text = "£" + drinkOrder.Cost().ToString();
        }

        /// <summary>
        /// process the Drink order
        /// </summary>
        private void ProcessOrder()
        {
            AbstractAcuCafeFactory AcuCafeFactory;

            try
            {
                switch ((Enum)cmbDrinks.SelectedItem)
                {
                    case AcuCafeEnum.EnumDrinks.EXPRESSO:
                        AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(IsCoffee);
                        drinkOrder = AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.EXPRESSO);
                        ProcessAddIns(IsCoffee);
                        break;
                    case AcuCafeEnum.EnumDrinks.RISTRETTO:
                        AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(IsCoffee);
                        drinkOrder = AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.RISTRETTO);
                        ProcessAddIns(IsCoffee);
                        break;
                    case AcuCafeEnum.EnumDrinks.LUNGO:
                        AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(IsCoffee);
                        drinkOrder = AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.LUNGO);
                        ProcessAddIns(IsCoffee);
                        break;
                    case AcuCafeEnum.EnumDrinks.TEA:
                        AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(IsTea);
                        drinkOrder = AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.TEA);
                        ProcessAddIns(IsTea);
                        break;
                    case AcuCafeEnum.EnumDrinks.ICETEA:
                        AcuCafeFactory = AcuCafeFactoryProducer.GetAcuCafeFactory(IsTea);
                        drinkOrder = AcuCafeFactory.GetDrink(AcuCafeEnum.EnumDrinks.ICETEA);
                        ProcessAddIns(IsTea);
                        break;
                    default:
                        throw new Exception("Undefine drink. We can not process the order.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        /// <summary>
        /// process the selected addIns
        /// </summary>
        /// <param name="isCoffee"></param>
        private void ProcessAddIns(bool isCoffee)
        {
            if (isCoffee)
                drinkOrder = AcuCafeAddInsRules.ProcessCoofeeAddIns(drinkOrder, ckbMilk.Checked, ckbSugar.Checked, ckbChocolate.Checked);
            else
                drinkOrder = AcuCafeAddInsRules.ProcessTeaAddIns(drinkOrder, ckbMilk.Checked, ckbSugar.Checked);

        }

        /// <summary>
        /// clean the AddIns after an order
        /// </summary>
        private void CleanAddIns()
        {
            ckbChocolate.Checked = false;
            ckbMilk.Checked = false;
            ckbSugar.Checked = false;
        }

    }


    
}
