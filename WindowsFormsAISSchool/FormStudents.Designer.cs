namespace WindowsFormsAISSchool
{
    partial class FormStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudents));
            System.Windows.Forms.Label код_ученикаLabel;
            System.Windows.Forms.Label фИО_ученикаLabel;
            System.Windows.Forms.Label классLabel;
            System.Windows.Forms.Label дата_оценки_1Label;
            System.Windows.Forms.Label код_предмета_1Label;
            System.Windows.Forms.Label оценка_1Label;
            System.Windows.Forms.Label дата_оценки_2Label;
            System.Windows.Forms.Label код_предмета_2Label;
            System.Windows.Forms.Label оценка_2Label;
            System.Windows.Forms.Label дата_оценки_3Label;
            System.Windows.Forms.Label код_предмета_3Label;
            System.Windows.Forms.Label оценка_3Label;
            this.label1 = new System.Windows.Forms.Label();
            this.schoolDataSet = new WindowsFormsAISSchool.SchoolDataSet();
            this.ученикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ученикиTableAdapter = new WindowsFormsAISSchool.SchoolDataSetTableAdapters.УченикиTableAdapter();
            this.tableAdapterManager = new WindowsFormsAISSchool.SchoolDataSetTableAdapters.TableAdapterManager();
            this.ученикиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ученикиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_ученикаTextBox = new System.Windows.Forms.TextBox();
            this.фИО_ученикаTextBox = new System.Windows.Forms.TextBox();
            this.классTextBox = new System.Windows.Forms.TextBox();
            this.оценкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оценкиTableAdapter = new WindowsFormsAISSchool.SchoolDataSetTableAdapters.ОценкиTableAdapter();
            this.дата_оценки_1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_предмета_1TextBox = new System.Windows.Forms.TextBox();
            this.оценка_1TextBox = new System.Windows.Forms.TextBox();
            this.дата_оценки_2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_предмета_2TextBox = new System.Windows.Forms.TextBox();
            this.оценка_2TextBox = new System.Windows.Forms.TextBox();
            this.дата_оценки_3DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_предмета_3TextBox = new System.Windows.Forms.TextBox();
            this.оценка_3TextBox = new System.Windows.Forms.TextBox();
            код_ученикаLabel = new System.Windows.Forms.Label();
            фИО_ученикаLabel = new System.Windows.Forms.Label();
            классLabel = new System.Windows.Forms.Label();
            дата_оценки_1Label = new System.Windows.Forms.Label();
            код_предмета_1Label = new System.Windows.Forms.Label();
            оценка_1Label = new System.Windows.Forms.Label();
            дата_оценки_2Label = new System.Windows.Forms.Label();
            код_предмета_2Label = new System.Windows.Forms.Label();
            оценка_2Label = new System.Windows.Forms.Label();
            дата_оценки_3Label = new System.Windows.Forms.Label();
            код_предмета_3Label = new System.Windows.Forms.Label();
            оценка_3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученикиBindingNavigator)).BeginInit();
            this.ученикиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(207, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(80, 30, 80, 30);
            this.label1.Size = new System.Drawing.Size(390, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список учеников";
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "SchoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ученикиBindingSource
            // 
            this.ученикиBindingSource.DataMember = "Ученики";
            this.ученикиBindingSource.DataSource = this.schoolDataSet;
            // 
            // ученикиTableAdapter
            // 
            this.ученикиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAISSchool.SchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ОценкиTableAdapter = this.оценкиTableAdapter;
            this.tableAdapterManager.ПредметыTableAdapter = null;
            this.tableAdapterManager.УченикиTableAdapter = this.ученикиTableAdapter;
            this.tableAdapterManager.УчителяTableAdapter = null;
            // 
            // ученикиBindingNavigator
            // 
            this.ученикиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ученикиBindingNavigator.BindingSource = this.ученикиBindingSource;
            this.ученикиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ученикиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ученикиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ученикиBindingNavigatorSaveItem});
            this.ученикиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ученикиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ученикиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ученикиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ученикиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ученикиBindingNavigator.Name = "ученикиBindingNavigator";
            this.ученикиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ученикиBindingNavigator.Size = new System.Drawing.Size(802, 25);
            this.ученикиBindingNavigator.TabIndex = 1;
            this.ученикиBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // ученикиBindingNavigatorSaveItem
            // 
            this.ученикиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ученикиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ученикиBindingNavigatorSaveItem.Image")));
            this.ученикиBindingNavigatorSaveItem.Name = "ученикиBindingNavigatorSaveItem";
            this.ученикиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ученикиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ученикиBindingNavigatorSaveItem.Click += new System.EventHandler(this.ученикиBindingNavigatorSaveItem_Click);
            // 
            // код_ученикаLabel
            // 
            код_ученикаLabel.AutoSize = true;
            код_ученикаLabel.BackColor = System.Drawing.Color.White;
            код_ученикаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            код_ученикаLabel.ForeColor = System.Drawing.Color.OliveDrab;
            код_ученикаLabel.Location = new System.Drawing.Point(37, 216);
            код_ученикаLabel.Name = "код_ученикаLabel";
            код_ученикаLabel.Size = new System.Drawing.Size(107, 20);
            код_ученикаLabel.TabIndex = 2;
            код_ученикаLabel.Text = "Код ученика:";
            // 
            // код_ученикаTextBox
            // 
            this.код_ученикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ученикиBindingSource, "Код ученика", true));
            this.код_ученикаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.код_ученикаTextBox.Location = new System.Drawing.Point(150, 213);
            this.код_ученикаTextBox.Name = "код_ученикаTextBox";
            this.код_ученикаTextBox.Size = new System.Drawing.Size(169, 26);
            this.код_ученикаTextBox.TabIndex = 3;
            // 
            // фИО_ученикаLabel
            // 
            фИО_ученикаLabel.AutoSize = true;
            фИО_ученикаLabel.BackColor = System.Drawing.Color.White;
            фИО_ученикаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            фИО_ученикаLabel.ForeColor = System.Drawing.Color.OliveDrab;
            фИО_ученикаLabel.Location = new System.Drawing.Point(29, 250);
            фИО_ученикаLabel.Name = "фИО_ученикаLabel";
            фИО_ученикаLabel.Size = new System.Drawing.Size(115, 20);
            фИО_ученикаLabel.TabIndex = 4;
            фИО_ученикаLabel.Text = "ФИО ученика:";
            // 
            // фИО_ученикаTextBox
            // 
            this.фИО_ученикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ученикиBindingSource, "ФИО ученика", true));
            this.фИО_ученикаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.фИО_ученикаTextBox.Location = new System.Drawing.Point(150, 247);
            this.фИО_ученикаTextBox.Name = "фИО_ученикаTextBox";
            this.фИО_ученикаTextBox.Size = new System.Drawing.Size(169, 26);
            this.фИО_ученикаTextBox.TabIndex = 5;
            // 
            // классLabel
            // 
            классLabel.AutoSize = true;
            классLabel.BackColor = System.Drawing.Color.White;
            классLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            классLabel.ForeColor = System.Drawing.Color.OliveDrab;
            классLabel.Location = new System.Drawing.Point(78, 285);
            классLabel.Name = "классLabel";
            классLabel.Size = new System.Drawing.Size(58, 20);
            классLabel.TabIndex = 6;
            классLabel.Text = "Класс:";
            классLabel.Click += new System.EventHandler(this.классLabel_Click);
            // 
            // классTextBox
            // 
            this.классTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ученикиBindingSource, "Класс", true));
            this.классTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.классTextBox.Location = new System.Drawing.Point(150, 279);
            this.классTextBox.Name = "классTextBox";
            this.классTextBox.Size = new System.Drawing.Size(169, 26);
            this.классTextBox.TabIndex = 7;
            this.классTextBox.TextChanged += new System.EventHandler(this.классTextBox_TextChanged);
            // 
            // оценкиBindingSource
            // 
            this.оценкиBindingSource.DataMember = "FK_Оценки_Ученики";
            this.оценкиBindingSource.DataSource = this.ученикиBindingSource;
            // 
            // оценкиTableAdapter
            // 
            this.оценкиTableAdapter.ClearBeforeFill = true;
            // 
            // дата_оценки_1Label
            // 
            дата_оценки_1Label.AutoSize = true;
            дата_оценки_1Label.BackColor = System.Drawing.Color.White;
            дата_оценки_1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_оценки_1Label.ForeColor = System.Drawing.Color.OliveDrab;
            дата_оценки_1Label.Location = new System.Drawing.Point(413, 130);
            дата_оценки_1Label.Name = "дата_оценки_1Label";
            дата_оценки_1Label.Size = new System.Drawing.Size(102, 16);
            дата_оценки_1Label.TabIndex = 8;
            дата_оценки_1Label.Text = "Дата оценки 1:";
            // 
            // дата_оценки_1DateTimePicker
            // 
            this.дата_оценки_1DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.оценкиBindingSource, "Дата оценки 1", true));
            this.дата_оценки_1DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_оценки_1DateTimePicker.Location = new System.Drawing.Point(535, 125);
            this.дата_оценки_1DateTimePicker.Name = "дата_оценки_1DateTimePicker";
            this.дата_оценки_1DateTimePicker.Size = new System.Drawing.Size(194, 22);
            this.дата_оценки_1DateTimePicker.TabIndex = 9;
            // 
            // код_предмета_1Label
            // 
            код_предмета_1Label.AutoSize = true;
            код_предмета_1Label.BackColor = System.Drawing.Color.White;
            код_предмета_1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_предмета_1Label.ForeColor = System.Drawing.Color.OliveDrab;
            код_предмета_1Label.Location = new System.Drawing.Point(413, 156);
            код_предмета_1Label.Name = "код_предмета_1Label";
            код_предмета_1Label.Size = new System.Drawing.Size(111, 16);
            код_предмета_1Label.TabIndex = 10;
            код_предмета_1Label.Text = "Код предмета 1:";
            // 
            // код_предмета_1TextBox
            // 
            this.код_предмета_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Код предмета 1", true));
            this.код_предмета_1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_предмета_1TextBox.Location = new System.Drawing.Point(535, 153);
            this.код_предмета_1TextBox.Name = "код_предмета_1TextBox";
            this.код_предмета_1TextBox.Size = new System.Drawing.Size(90, 22);
            this.код_предмета_1TextBox.TabIndex = 11;
            this.код_предмета_1TextBox.TextChanged += new System.EventHandler(this.код_предмета_1TextBox_TextChanged);
            // 
            // оценка_1Label
            // 
            оценка_1Label.AutoSize = true;
            оценка_1Label.BackColor = System.Drawing.Color.White;
            оценка_1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            оценка_1Label.ForeColor = System.Drawing.Color.OliveDrab;
            оценка_1Label.Location = new System.Drawing.Point(413, 185);
            оценка_1Label.Name = "оценка_1Label";
            оценка_1Label.Size = new System.Drawing.Size(69, 16);
            оценка_1Label.TabIndex = 12;
            оценка_1Label.Text = "Оценка 1:";
            оценка_1Label.Click += new System.EventHandler(this.оценка_1Label_Click);
            // 
            // оценка_1TextBox
            // 
            this.оценка_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Оценка 1", true));
            this.оценка_1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.оценка_1TextBox.Location = new System.Drawing.Point(535, 185);
            this.оценка_1TextBox.Name = "оценка_1TextBox";
            this.оценка_1TextBox.Size = new System.Drawing.Size(90, 22);
            this.оценка_1TextBox.TabIndex = 13;
            // 
            // дата_оценки_2Label
            // 
            дата_оценки_2Label.AutoSize = true;
            дата_оценки_2Label.BackColor = System.Drawing.Color.White;
            дата_оценки_2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_оценки_2Label.ForeColor = System.Drawing.Color.OliveDrab;
            дата_оценки_2Label.Location = new System.Drawing.Point(413, 237);
            дата_оценки_2Label.Name = "дата_оценки_2Label";
            дата_оценки_2Label.Size = new System.Drawing.Size(102, 16);
            дата_оценки_2Label.TabIndex = 14;
            дата_оценки_2Label.Text = "Дата оценки 2:";
            // 
            // дата_оценки_2DateTimePicker
            // 
            this.дата_оценки_2DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.оценкиBindingSource, "Дата оценки 2", true));
            this.дата_оценки_2DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_оценки_2DateTimePicker.Location = new System.Drawing.Point(534, 231);
            this.дата_оценки_2DateTimePicker.Name = "дата_оценки_2DateTimePicker";
            this.дата_оценки_2DateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_оценки_2DateTimePicker.TabIndex = 15;
            // 
            // код_предмета_2Label
            // 
            код_предмета_2Label.AutoSize = true;
            код_предмета_2Label.BackColor = System.Drawing.Color.White;
            код_предмета_2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_предмета_2Label.ForeColor = System.Drawing.Color.OliveDrab;
            код_предмета_2Label.Location = new System.Drawing.Point(413, 262);
            код_предмета_2Label.Name = "код_предмета_2Label";
            код_предмета_2Label.Size = new System.Drawing.Size(111, 16);
            код_предмета_2Label.TabIndex = 16;
            код_предмета_2Label.Text = "Код предмета 2:";
            // 
            // код_предмета_2TextBox
            // 
            this.код_предмета_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Код предмета 2", true));
            this.код_предмета_2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_предмета_2TextBox.Location = new System.Drawing.Point(534, 256);
            this.код_предмета_2TextBox.Name = "код_предмета_2TextBox";
            this.код_предмета_2TextBox.Size = new System.Drawing.Size(100, 22);
            this.код_предмета_2TextBox.TabIndex = 17;
            // 
            // оценка_2Label
            // 
            оценка_2Label.AutoSize = true;
            оценка_2Label.BackColor = System.Drawing.Color.White;
            оценка_2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            оценка_2Label.ForeColor = System.Drawing.Color.OliveDrab;
            оценка_2Label.Location = new System.Drawing.Point(413, 290);
            оценка_2Label.Name = "оценка_2Label";
            оценка_2Label.Size = new System.Drawing.Size(69, 16);
            оценка_2Label.TabIndex = 18;
            оценка_2Label.Text = "Оценка 2:";
            оценка_2Label.Click += new System.EventHandler(this.оценка_2Label_Click);
            // 
            // оценка_2TextBox
            // 
            this.оценка_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Оценка 2", true));
            this.оценка_2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.оценка_2TextBox.Location = new System.Drawing.Point(534, 284);
            this.оценка_2TextBox.Name = "оценка_2TextBox";
            this.оценка_2TextBox.Size = new System.Drawing.Size(100, 22);
            this.оценка_2TextBox.TabIndex = 19;
            // 
            // дата_оценки_3Label
            // 
            дата_оценки_3Label.AutoSize = true;
            дата_оценки_3Label.BackColor = System.Drawing.Color.White;
            дата_оценки_3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_оценки_3Label.ForeColor = System.Drawing.Color.OliveDrab;
            дата_оценки_3Label.Location = new System.Drawing.Point(413, 346);
            дата_оценки_3Label.Name = "дата_оценки_3Label";
            дата_оценки_3Label.Size = new System.Drawing.Size(102, 16);
            дата_оценки_3Label.TabIndex = 20;
            дата_оценки_3Label.Text = "Дата оценки 3:";
            // 
            // дата_оценки_3DateTimePicker
            // 
            this.дата_оценки_3DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.оценкиBindingSource, "Дата оценки 3", true));
            this.дата_оценки_3DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_оценки_3DateTimePicker.Location = new System.Drawing.Point(530, 341);
            this.дата_оценки_3DateTimePicker.Name = "дата_оценки_3DateTimePicker";
            this.дата_оценки_3DateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_оценки_3DateTimePicker.TabIndex = 21;
            // 
            // код_предмета_3Label
            // 
            код_предмета_3Label.AutoSize = true;
            код_предмета_3Label.BackColor = System.Drawing.Color.White;
            код_предмета_3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_предмета_3Label.ForeColor = System.Drawing.Color.OliveDrab;
            код_предмета_3Label.Location = new System.Drawing.Point(413, 371);
            код_предмета_3Label.Name = "код_предмета_3Label";
            код_предмета_3Label.Size = new System.Drawing.Size(111, 16);
            код_предмета_3Label.TabIndex = 22;
            код_предмета_3Label.Text = "Код предмета 3:";
            // 
            // код_предмета_3TextBox
            // 
            this.код_предмета_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Код предмета 3", true));
            this.код_предмета_3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_предмета_3TextBox.Location = new System.Drawing.Point(530, 368);
            this.код_предмета_3TextBox.Name = "код_предмета_3TextBox";
            this.код_предмета_3TextBox.Size = new System.Drawing.Size(100, 22);
            this.код_предмета_3TextBox.TabIndex = 23;
            // 
            // оценка_3Label
            // 
            оценка_3Label.AutoSize = true;
            оценка_3Label.BackColor = System.Drawing.Color.White;
            оценка_3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            оценка_3Label.ForeColor = System.Drawing.Color.OliveDrab;
            оценка_3Label.Location = new System.Drawing.Point(413, 399);
            оценка_3Label.Name = "оценка_3Label";
            оценка_3Label.Size = new System.Drawing.Size(69, 16);
            оценка_3Label.TabIndex = 24;
            оценка_3Label.Text = "Оценка 3:";
            оценка_3Label.Click += new System.EventHandler(this.оценка_3Label_Click);
            // 
            // оценка_3TextBox
            // 
            this.оценка_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Оценка 3", true));
            this.оценка_3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.оценка_3TextBox.Location = new System.Drawing.Point(530, 396);
            this.оценка_3TextBox.Name = "оценка_3TextBox";
            this.оценка_3TextBox.Size = new System.Drawing.Size(100, 22);
            this.оценка_3TextBox.TabIndex = 25;
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(217)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(оценка_3Label);
            this.Controls.Add(this.оценка_3TextBox);
            this.Controls.Add(код_предмета_3Label);
            this.Controls.Add(this.код_предмета_3TextBox);
            this.Controls.Add(дата_оценки_3Label);
            this.Controls.Add(this.дата_оценки_3DateTimePicker);
            this.Controls.Add(оценка_2Label);
            this.Controls.Add(this.оценка_2TextBox);
            this.Controls.Add(код_предмета_2Label);
            this.Controls.Add(this.код_предмета_2TextBox);
            this.Controls.Add(дата_оценки_2Label);
            this.Controls.Add(this.дата_оценки_2DateTimePicker);
            this.Controls.Add(оценка_1Label);
            this.Controls.Add(this.оценка_1TextBox);
            this.Controls.Add(код_предмета_1Label);
            this.Controls.Add(this.код_предмета_1TextBox);
            this.Controls.Add(дата_оценки_1Label);
            this.Controls.Add(this.дата_оценки_1DateTimePicker);
            this.Controls.Add(классLabel);
            this.Controls.Add(this.классTextBox);
            this.Controls.Add(фИО_ученикаLabel);
            this.Controls.Add(this.фИО_ученикаTextBox);
            this.Controls.Add(код_ученикаLabel);
            this.Controls.Add(this.код_ученикаTextBox);
            this.Controls.Add(this.ученикиBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "FormStudents";
            this.Text = "Классы";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученикиBindingNavigator)).EndInit();
            this.ученикиBindingNavigator.ResumeLayout(false);
            this.ученикиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SchoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource ученикиBindingSource;
        private SchoolDataSetTableAdapters.УченикиTableAdapter ученикиTableAdapter;
        private SchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ученикиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ученикиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_ученикаTextBox;
        private System.Windows.Forms.TextBox фИО_ученикаTextBox;
        private System.Windows.Forms.TextBox классTextBox;
        private SchoolDataSetTableAdapters.ОценкиTableAdapter оценкиTableAdapter;
        private System.Windows.Forms.BindingSource оценкиBindingSource;
        private System.Windows.Forms.DateTimePicker дата_оценки_1DateTimePicker;
        private System.Windows.Forms.TextBox код_предмета_1TextBox;
        private System.Windows.Forms.TextBox оценка_1TextBox;
        private System.Windows.Forms.DateTimePicker дата_оценки_2DateTimePicker;
        private System.Windows.Forms.TextBox код_предмета_2TextBox;
        private System.Windows.Forms.TextBox оценка_2TextBox;
        private System.Windows.Forms.DateTimePicker дата_оценки_3DateTimePicker;
        private System.Windows.Forms.TextBox код_предмета_3TextBox;
        private System.Windows.Forms.TextBox оценка_3TextBox;
    }
}