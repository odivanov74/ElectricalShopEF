
namespace ElectricalDevicesEF.View.ShopView
{
    partial class ShopForm
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
            this.DiscountSum_Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddBasket_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BasketNames_ComboBox = new System.Windows.Forms.ComboBox();
            this.PriceBasket_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Buy_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Basket_ListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeviceInfo_Label = new System.Windows.Forms.Label();
            this.UserName_Label = new System.Windows.Forms.Label();
            this.NumDevices_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InBasket_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductModels_ListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumDevices_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DiscountSum_Label
            // 
            this.DiscountSum_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiscountSum_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountSum_Label.Location = new System.Drawing.Point(641, 262);
            this.DiscountSum_Label.Name = "DiscountSum_Label";
            this.DiscountSum_Label.Size = new System.Drawing.Size(108, 23);
            this.DiscountSum_Label.TabIndex = 37;
            this.DiscountSum_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(591, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Скидка:";
            // 
            // AddBasket_Button
            // 
            this.AddBasket_Button.Location = new System.Drawing.Point(704, 39);
            this.AddBasket_Button.Name = "AddBasket_Button";
            this.AddBasket_Button.Size = new System.Drawing.Size(48, 21);
            this.AddBasket_Button.TabIndex = 35;
            this.AddBasket_Button.Text = "+";
            this.AddBasket_Button.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Корзина:";
            // 
            // BasketNames_ComboBox
            // 
            this.BasketNames_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BasketNames_ComboBox.FormattingEnabled = true;
            this.BasketNames_ComboBox.Location = new System.Drawing.Point(525, 39);
            this.BasketNames_ComboBox.Name = "BasketNames_ComboBox";
            this.BasketNames_ComboBox.Size = new System.Drawing.Size(173, 21);
            this.BasketNames_ComboBox.TabIndex = 33;
            // 
            // PriceBasket_Label
            // 
            this.PriceBasket_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceBasket_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceBasket_Label.Location = new System.Drawing.Point(641, 292);
            this.PriceBasket_Label.Name = "PriceBasket_Label";
            this.PriceBasket_Label.Size = new System.Drawing.Size(108, 23);
            this.PriceBasket_Label.TabIndex = 32;
            this.PriceBasket_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "ИТОГО:";
            // 
            // Buy_Button
            // 
            this.Buy_Button.Location = new System.Drawing.Point(525, 326);
            this.Buy_Button.Name = "Buy_Button";
            this.Buy_Button.Size = new System.Drawing.Size(224, 29);
            this.Buy_Button.TabIndex = 30;
            this.Buy_Button.Text = "Купить";
            this.Buy_Button.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Содержимое корзины:";
            // 
            // Basket_ListBox
            // 
            this.Basket_ListBox.FormattingEnabled = true;
            this.Basket_ListBox.Location = new System.Drawing.Point(525, 78);
            this.Basket_ListBox.Name = "Basket_ListBox";
            this.Basket_ListBox.Size = new System.Drawing.Size(224, 173);
            this.Basket_ListBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Информация о товаре:";
            // 
            // DeviceInfo_Label
            // 
            this.DeviceInfo_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeviceInfo_Label.Location = new System.Drawing.Point(355, 39);
            this.DeviceInfo_Label.Name = "DeviceInfo_Label";
            this.DeviceInfo_Label.Size = new System.Drawing.Size(160, 241);
            this.DeviceInfo_Label.TabIndex = 26;
            // 
            // UserName_Label
            // 
            this.UserName_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserName_Label.Location = new System.Drawing.Point(521, 5);
            this.UserName_Label.Name = "UserName_Label";
            this.UserName_Label.Size = new System.Drawing.Size(224, 13);
            this.UserName_Label.TabIndex = 25;
            this.UserName_Label.Text = "User";
            this.UserName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumDevices_NumericUpDown
            // 
            this.NumDevices_NumericUpDown.Location = new System.Drawing.Point(355, 296);
            this.NumDevices_NumericUpDown.Name = "NumDevices_NumericUpDown";
            this.NumDevices_NumericUpDown.Size = new System.Drawing.Size(160, 20);
            this.NumDevices_NumericUpDown.TabIndex = 24;
            // 
            // InBasket_button
            // 
            this.InBasket_button.Location = new System.Drawing.Point(355, 326);
            this.InBasket_button.Name = "InBasket_button";
            this.InBasket_button.Size = new System.Drawing.Size(160, 29);
            this.InBasket_button.TabIndex = 23;
            this.InBasket_button.Text = "В корзину";
            this.InBasket_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Список товаров:";
            // 
            // ProductModels_ListBox
            // 
            this.ProductModels_ListBox.FormattingEnabled = true;
            this.ProductModels_ListBox.Location = new System.Drawing.Point(15, 39);
            this.ProductModels_ListBox.Name = "ProductModels_ListBox";
            this.ProductModels_ListBox.Size = new System.Drawing.Size(334, 316);
            this.ProductModels_ListBox.TabIndex = 21;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 369);
            this.Controls.Add(this.DiscountSum_Label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddBasket_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BasketNames_ComboBox);
            this.Controls.Add(this.PriceBasket_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Buy_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Basket_ListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeviceInfo_Label);
            this.Controls.Add(this.UserName_Label);
            this.Controls.Add(this.NumDevices_NumericUpDown);
            this.Controls.Add(this.InBasket_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductModels_ListBox);
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumDevices_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DiscountSum_Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddBasket_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox BasketNames_ComboBox;
        private System.Windows.Forms.Label PriceBasket_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Buy_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Basket_ListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DeviceInfo_Label;
        private System.Windows.Forms.Label UserName_Label;
        private System.Windows.Forms.NumericUpDown NumDevices_NumericUpDown;
        private System.Windows.Forms.Button InBasket_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ProductModels_ListBox;
    }
}