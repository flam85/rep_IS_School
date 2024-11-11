namespace WindowsFormsAISSchool
{
    partial class FormTeachers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label фИО_учителяLabel;
            System.Windows.Forms.Label код_руководителяLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeachers));
            System.Windows.Forms.Label классLabel;
            System.Windows.Forms.Label код_предметаLabel;
            this.schoolDataSet = new WindowsFormsAISSchool.SchoolDataSet();
            this.учителяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учителяTableAdapter = new WindowsFormsAISSchool.SchoolDataSetTableAdapters.УчителяTableAdapter();
            this.tableAdapterManager = new WindowsFormsAISSchool.SchoolDataSetTableAdapters.TableAdapterManager();
            this.учителяBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.учителяBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фИО_учителяTextBox = new System.Windows.Forms.TextBox();
            this.код_руководителяTextBox = new System.Windows.Forms.TextBox();
            this.классTextBox = new System.Windows.Forms.TextBox();
            this.код_предметаTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            фИО_учителяLabel = new System.Windows.Forms.Label();
            код_руководителяLabel = new System.Windows.Forms.Label();
            классLabel = new System.Windows.Forms.Label();
            код_предметаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учителяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учителяBindingNavigator)).BeginInit();
            this.учителяBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // фИО_учителяLabel
            // 
            фИО_учителяLabel.AutoSize = true;
            фИО_учителяLabel.BackColor = System.Drawing.Color.White;
            фИО_учителяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            фИО_учителяLabel.ForeColor = System.Drawing.Color.OliveDrab;
            фИО_учителяLabel.Location = new System.Drawing.Point(262, 229);
            фИО_учителяLabel.Name = "фИО_учителяLabel";
            фИО_учителяLabel.Size = new System.Drawing.Size(117, 20);
            фИО_учителяLabel.TabIndex = 1;
            фИО_учителяLabel.Text = "ФИО учителя:";
            // 
            // код_руководителяLabel
            // 
            код_руководителяLabel.AutoSize = true;
            код_руководителяLabel.BackColor = System.Drawing.Color.White;
            код_руководителяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            код_руководителяLabel.ForeColor = System.Drawing.Color.OliveDrab;
            код_руководителяLabel.Location = new System.Drawing.Point(262, 197);
            код_руководителяLabel.Name = "код_руководителяLabel";
            код_руководителяLabel.Size = new System.Drawing.Size(155, 20);
            код_руководителяLabel.TabIndex = 3;
            код_руководителяLabel.Text = "Код руководителя:";
            код_руководителяLabel.Click += new System.EventHandler(this.код_руководителяLabel_Click);
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "SchoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // учителяBindingSource
            // 
            this.учителяBindingSource.DataMember = "Учителя";
            this.учителяBindingSource.DataSource = this.schoolDataSet;
            // 
            // учителяTableAdapter
            // 
            this.учителяTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAISSchool.SchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ОценкиTableAdapter = null;
            this.tableAdapterManager.ПредметыTableAdapter = null;
            this.tableAdapterManager.УченикиTableAdapter = null;
            this.tableAdapterManager.УчителяTableAdapter = this.учителяTableAdapter;
            // 
            // учителяBindingNavigator
            // 
            this.учителяBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.учителяBindingNavigator.BindingSource = this.учителяBindingSource;
            this.учителяBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.учителяBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.учителяBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.учителяBindingNavigatorSaveItem});
            this.учителяBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.учителяBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.учителяBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.учителяBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.учителяBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.учителяBindingNavigator.Name = "учителяBindingNavigator";
            this.учителяBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.учителяBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.учителяBindingNavigator.TabIndex = 0;
            this.учителяBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // учителяBindingNavigatorSaveItem
            // 
            this.учителяBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.учителяBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("учителяBindingNavigatorSaveItem.Image")));
            this.учителяBindingNavigatorSaveItem.Name = "учителяBindingNavigatorSaveItem";
            this.учителяBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.учителяBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.учителяBindingNavigatorSaveItem.Click += new System.EventHandler(this.учителяBindingNavigatorSaveItem_Click_1);
            // 
            // фИО_учителяTextBox
            // 
            this.фИО_учителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учителяBindingSource, "ФИО учителя", true));
            this.фИО_учителяTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.фИО_учителяTextBox.Location = new System.Drawing.Point(385, 226);
            this.фИО_учителяTextBox.Name = "фИО_учителяTextBox";
            this.фИО_учителяTextBox.Size = new System.Drawing.Size(155, 26);
            this.фИО_учителяTextBox.TabIndex = 2;
            // 
            // код_руководителяTextBox
            // 
            this.код_руководителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учителяBindingSource, "Код руководителя", true));
            this.код_руководителяTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.код_руководителяTextBox.Location = new System.Drawing.Point(427, 194);
            this.код_руководителяTextBox.Name = "код_руководителяTextBox";
            this.код_руководителяTextBox.Size = new System.Drawing.Size(113, 26);
            this.код_руководителяTextBox.TabIndex = 4;
            // 
            // классLabel
            // 
            классLabel.AutoSize = true;
            классLabel.BackColor = System.Drawing.Color.White;
            классLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            классLabel.ForeColor = System.Drawing.Color.OliveDrab;
            классLabel.Location = new System.Drawing.Point(262, 262);
            классLabel.Name = "классLabel";
            классLabel.Size = new System.Drawing.Size(58, 20);
            классLabel.TabIndex = 5;
            классLabel.Text = "Класс:";
            // 
            // классTextBox
            // 
            this.классTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учителяBindingSource, "Класс", true));
            this.классTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.классTextBox.Location = new System.Drawing.Point(352, 258);
            this.классTextBox.Name = "классTextBox";
            this.классTextBox.Size = new System.Drawing.Size(188, 26);
            this.классTextBox.TabIndex = 6;
            // 
            // код_предметаLabel
            // 
            код_предметаLabel.AutoSize = true;
            код_предметаLabel.BackColor = System.Drawing.Color.White;
            код_предметаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            код_предметаLabel.ForeColor = System.Drawing.Color.OliveDrab;
            код_предметаLabel.Location = new System.Drawing.Point(262, 296);
            код_предметаLabel.Name = "код_предметаLabel";
            код_предметаLabel.Size = new System.Drawing.Size(123, 20);
            код_предметаLabel.TabIndex = 7;
            код_предметаLabel.Text = "Код предмета:";
            // 
            // код_предметаTextBox
            // 
            this.код_предметаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учителяBindingSource, "Код предмета", true));
            this.код_предметаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.код_предметаTextBox.Location = new System.Drawing.Point(398, 290);
            this.код_предметаTextBox.Name = "код_предметаTextBox";
            this.код_предметаTextBox.Size = new System.Drawing.Size(142, 26);
            this.код_предметаTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(271, 49);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20);
            this.label1.Size = new System.Drawing.Size(269, 71);
            this.label1.TabIndex = 9;
            this.label1.Text = "Список учителей";
            // 
            // FormTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(217)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(код_предметаLabel);
            this.Controls.Add(this.код_предметаTextBox);
            this.Controls.Add(классLabel);
            this.Controls.Add(this.классTextBox);
            this.Controls.Add(код_руководителяLabel);
            this.Controls.Add(this.код_руководителяTextBox);
            this.Controls.Add(фИО_учителяLabel);
            this.Controls.Add(this.фИО_учителяTextBox);
            this.Controls.Add(this.учителяBindingNavigator);
            this.Name = "FormTeachers";
            this.Text = "Учителя";
            this.Load += new System.EventHandler(this.FormTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учителяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учителяBindingNavigator)).EndInit();
            this.учителяBindingNavigator.ResumeLayout(false);
            this.учителяBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SchoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource учителяBindingSource;
        private SchoolDataSetTableAdapters.УчителяTableAdapter учителяTableAdapter;
        private SchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator учителяBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton учителяBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox фИО_учителяTextBox;
        private System.Windows.Forms.TextBox код_руководителяTextBox;
        private System.Windows.Forms.TextBox классTextBox;
        private System.Windows.Forms.TextBox код_предметаTextBox;
        private System.Windows.Forms.Label label1;
    }
}