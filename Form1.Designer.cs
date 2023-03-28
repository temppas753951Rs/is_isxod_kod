namespace UchZayavka
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видыОрганизацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.организацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыОбработкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыЗаявокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусыЗаявителейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бланкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бланкОтчетаПоЗаявкеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бланкШаблонаОтчетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗаявокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗаявителейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыОбработкиЗаявокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаПриемаЗаявокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаЗаявокПоСтатусамЗаявителейИВидамЗаявокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодЗаявителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.заявительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new UchZayavka.BDDataSet();
            this.кодОрганизацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.организацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодВидаЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.кодВидаЗаявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодСпособаПолученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.способПолученияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.комментарииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.КомуОтправлена = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.контактныеДанныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.заявкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодЗаявителяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.КодСтатуса = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.статусЗаявителяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet1 = new UchZayavka.BDDataSet();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.электроннаяПочтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.документыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расширениеАрхиваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.заявительBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.кодРезультатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодЗаявкиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.заявкаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.датаРассмотренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ктоРассмотрелDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодРезультатаРассмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.результатыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.комментарииDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.результатыОбработкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.заявкаTableAdapter = new UchZayavka.BDDataSetTableAdapters.ЗаявкаTableAdapter();
            this.заявительTableAdapter = new UchZayavka.BDDataSetTableAdapters.ЗаявительTableAdapter();
            this.организацияTableAdapter = new UchZayavka.BDDataSetTableAdapters.ОрганизацияTableAdapter();
            this.заявкаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.кодВидаЗаявкиTableAdapter = new UchZayavka.BDDataSetTableAdapters.КодВидаЗаявкиTableAdapter();
            this.способПолученияTableAdapter = new UchZayavka.BDDataSetTableAdapters.СпособПолученияTableAdapter();
            this.сотрудникиTableAdapter = new UchZayavka.BDDataSetTableAdapters.СотрудникиTableAdapter();
            this.результатыОбработкиTableAdapter = new UchZayavka.BDDataSetTableAdapters.РезультатыОбработкиTableAdapter();
            this.кодВидаЗаявкиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.видОрганизацииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.видОрганизацииTableAdapter = new UchZayavka.BDDataSetTableAdapters.ВидОрганизацииTableAdapter();
            this.результатыTableAdapter = new UchZayavka.BDDataSetTableAdapters.РезультатыTableAdapter();
            this.статусЗаявителяTableAdapter = new UchZayavka.BDDataSetTableAdapters.СтатусЗаявителяTableAdapter();
            this.контактныеДанныеTableAdapter = new UchZayavka.BDDataSetTableAdapters.КонтактныеДанныеTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кодВидаЗаявкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.способПолученияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактныеДанныеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусЗаявителяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявительBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.результатыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.результатыОбработкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кодВидаЗаявкиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видОрганизацииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникToolStripMenuItem,
            this.бланкиToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(945, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Image = global::UchZayavka.Properties.Resources.premium_icon_financial_report_38895191;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.файлToolStripMenuItem.Text = "Выход";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видыОрганизацийToolStripMenuItem,
            this.организацииToolStripMenuItem,
            this.результатыОбработкиToolStripMenuItem,
            this.группыЗаявокToolStripMenuItem,
            this.статусыЗаявителейToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.пользователиToolStripMenuItem});
            this.справочникToolStripMenuItem.Image = global::UchZayavka.Properties.Resources.premium_icon_handbook_4152972;
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(126, 36);
            this.справочникToolStripMenuItem.Text = "Справочники";
            // 
            // видыОрганизацийToolStripMenuItem
            // 
            this.видыОрганизацийToolStripMenuItem.Name = "видыОрганизацийToolStripMenuItem";
            this.видыОрганизацийToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.видыОрганизацийToolStripMenuItem.Text = "Отделы";
            this.видыОрганизацийToolStripMenuItem.Click += new System.EventHandler(this.видыОрганизацийToolStripMenuItem_Click);
            // 
            // организацииToolStripMenuItem
            // 
            this.организацииToolStripMenuItem.Name = "организацииToolStripMenuItem";
            this.организацииToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.организацииToolStripMenuItem.Text = "Виды обращений";
            this.организацииToolStripMenuItem.Click += new System.EventHandler(this.организацииToolStripMenuItem_Click);
            // 
            // результатыОбработкиToolStripMenuItem
            // 
            this.результатыОбработкиToolStripMenuItem.Name = "результатыОбработкиToolStripMenuItem";
            this.результатыОбработкиToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.результатыОбработкиToolStripMenuItem.Text = "Результаты обработки обращений";
            this.результатыОбработкиToolStripMenuItem.Click += new System.EventHandler(this.результатыОбработкиToolStripMenuItem_Click);
            // 
            // группыЗаявокToolStripMenuItem
            // 
            this.группыЗаявокToolStripMenuItem.Name = "группыЗаявокToolStripMenuItem";
            this.группыЗаявокToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.группыЗаявокToolStripMenuItem.Text = "Группы обращений";
            this.группыЗаявокToolStripMenuItem.Click += new System.EventHandler(this.группыЗаявокToolStripMenuItem_Click);
            // 
            // статусыЗаявителейToolStripMenuItem
            // 
            this.статусыЗаявителейToolStripMenuItem.Name = "статусыЗаявителейToolStripMenuItem";
            this.статусыЗаявителейToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.статусыЗаявителейToolStripMenuItem.Text = "Статусы заявителей";
            this.статусыЗаявителейToolStripMenuItem.Click += new System.EventHandler(this.статусыЗаявителейToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи [для администратора]";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // бланкиToolStripMenuItem
            // 
            this.бланкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бланкОтчетаПоЗаявкеToolStripMenuItem,
            this.бланкШаблонаОтчетаToolStripMenuItem});
            this.бланкиToolStripMenuItem.Image = global::UchZayavka.Properties.Resources.premium_icon_letterhead_4747937;
            this.бланкиToolStripMenuItem.Name = "бланкиToolStripMenuItem";
            this.бланкиToolStripMenuItem.Size = new System.Drawing.Size(91, 36);
            this.бланкиToolStripMenuItem.Text = "Бланки";
            // 
            // бланкОтчетаПоЗаявкеToolStripMenuItem
            // 
            this.бланкОтчетаПоЗаявкеToolStripMenuItem.Name = "бланкОтчетаПоЗаявкеToolStripMenuItem";
            this.бланкОтчетаПоЗаявкеToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.бланкОтчетаПоЗаявкеToolStripMenuItem.Text = "Бланк обращения";
            this.бланкОтчетаПоЗаявкеToolStripMenuItem.Click += new System.EventHandler(this.бланкОтчетаПоЗаявкеToolStripMenuItem_Click);
            // 
            // бланкШаблонаОтчетаToolStripMenuItem
            // 
            this.бланкШаблонаОтчетаToolStripMenuItem.Name = "бланкШаблонаОтчетаToolStripMenuItem";
            this.бланкШаблонаОтчетаToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.бланкШаблонаОтчетаToolStripMenuItem.Text = "Бланк шаблона отчета";
            this.бланкШаблонаОтчетаToolStripMenuItem.Click += new System.EventHandler(this.бланкШаблонаОтчетаToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокЗаявокToolStripMenuItem,
            this.списокЗаявителейToolStripMenuItem,
            this.результатыОбработкиЗаявокToolStripMenuItem,
            this.статистикаПриемаЗаявокToolStripMenuItem,
            this.статистикаЗаявокПоСтатусамЗаявителейИВидамЗаявокToolStripMenuItem});
            this.отчетыToolStripMenuItem.Image = global::UchZayavka.Properties.Resources.premium_icon_financial_report_3889519;
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // списокЗаявокToolStripMenuItem
            // 
            this.списокЗаявокToolStripMenuItem.Name = "списокЗаявокToolStripMenuItem";
            this.списокЗаявокToolStripMenuItem.Size = new System.Drawing.Size(451, 22);
            this.списокЗаявокToolStripMenuItem.Text = "Список обращений";
            this.списокЗаявокToolStripMenuItem.Click += new System.EventHandler(this.списокЗаявокToolStripMenuItem_Click);
            // 
            // списокЗаявителейToolStripMenuItem
            // 
            this.списокЗаявителейToolStripMenuItem.Name = "списокЗаявителейToolStripMenuItem";
            this.списокЗаявителейToolStripMenuItem.Size = new System.Drawing.Size(451, 22);
            this.списокЗаявителейToolStripMenuItem.Text = "Список заявителей";
            this.списокЗаявителейToolStripMenuItem.Click += new System.EventHandler(this.списокЗаявителейToolStripMenuItem_Click);
            // 
            // результатыОбработкиЗаявокToolStripMenuItem
            // 
            this.результатыОбработкиЗаявокToolStripMenuItem.Name = "результатыОбработкиЗаявокToolStripMenuItem";
            this.результатыОбработкиЗаявокToolStripMenuItem.Size = new System.Drawing.Size(451, 22);
            this.результатыОбработкиЗаявокToolStripMenuItem.Text = "Результаты обработки обращений";
            this.результатыОбработкиЗаявокToolStripMenuItem.Click += new System.EventHandler(this.результатыОбработкиЗаявокToolStripMenuItem_Click);
            // 
            // статистикаПриемаЗаявокToolStripMenuItem
            // 
            this.статистикаПриемаЗаявокToolStripMenuItem.Name = "статистикаПриемаЗаявокToolStripMenuItem";
            this.статистикаПриемаЗаявокToolStripMenuItem.Size = new System.Drawing.Size(451, 22);
            this.статистикаПриемаЗаявокToolStripMenuItem.Text = "Статистика приема и обработки обращений";
            this.статистикаПриемаЗаявокToolStripMenuItem.Click += new System.EventHandler(this.статистикаПриемаЗаявокToolStripMenuItem_Click);
            // 
            // статистикаЗаявокПоСтатусамЗаявителейИВидамЗаявокToolStripMenuItem
            // 
            this.статистикаЗаявокПоСтатусамЗаявителейИВидамЗаявокToolStripMenuItem.Name = "статистикаЗаявокПоСтатусамЗаявителейИВидамЗаявокToolStripMenuItem";
            this.статистикаЗаявокПоСтатусамЗаявителейИВидамЗаявокToolStripMenuItem.Size = new System.Drawing.Size(451, 22);
            this.статистикаЗаявокПоСтатусамЗаявителейИВидамЗаявокToolStripMenuItem.Text = "Статистика обращений по статусам заявителей и видам обращений";
            this.статистикаЗаявокПоСтатусамЗаявителейИВидамЗаявокToolStripMenuItem.Click += new System.EventHandler(this.статистикаЗаявокПоСтатусамЗаявителейИВидамЗаявокToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 466);
            this.panel1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(200, 453);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Обращения";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 40);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 466);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(203, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 466);
            this.panel2.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 456);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.bindingNavigator2);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Обращения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 49);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Size = new System.Drawing.Size(728, 369);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЗаявкиDataGridViewTextBoxColumn,
            this.номерЗаявкиDataGridViewTextBoxColumn,
            this.датаЗаявкиDataGridViewTextBoxColumn,
            this.кодЗаявителяDataGridViewTextBoxColumn,
            this.кодОрганизацииDataGridViewTextBoxColumn,
            this.кодВидаЗаявкиDataGridViewTextBoxColumn,
            this.кодСпособаПолученияDataGridViewTextBoxColumn,
            this.комментарииDataGridViewTextBoxColumn,
            this.кодСотрудникаDataGridViewTextBoxColumn,
            this.КомуОтправлена,
            this.Column3,
            this.Column4});
            this.dataGridView2.DataSource = this.заявкаBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(728, 274);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // кодЗаявкиDataGridViewTextBoxColumn
            // 
            this.кодЗаявкиDataGridViewTextBoxColumn.DataPropertyName = "КодЗаявки";
            this.кодЗаявкиDataGridViewTextBoxColumn.HeaderText = "КодЗаявки";
            this.кодЗаявкиDataGridViewTextBoxColumn.Name = "кодЗаявкиDataGridViewTextBoxColumn";
            this.кодЗаявкиDataGridViewTextBoxColumn.Visible = false;
            // 
            // номерЗаявкиDataGridViewTextBoxColumn
            // 
            this.номерЗаявкиDataGridViewTextBoxColumn.DataPropertyName = "НомерЗаявки";
            this.номерЗаявкиDataGridViewTextBoxColumn.HeaderText = "Номер обращения";
            this.номерЗаявкиDataGridViewTextBoxColumn.Name = "номерЗаявкиDataGridViewTextBoxColumn";
            // 
            // датаЗаявкиDataGridViewTextBoxColumn
            // 
            this.датаЗаявкиDataGridViewTextBoxColumn.DataPropertyName = "ДатаЗаявки";
            this.датаЗаявкиDataGridViewTextBoxColumn.HeaderText = "Дата обращения";
            this.датаЗаявкиDataGridViewTextBoxColumn.Name = "датаЗаявкиDataGridViewTextBoxColumn";
            // 
            // кодЗаявителяDataGridViewTextBoxColumn
            // 
            this.кодЗаявителяDataGridViewTextBoxColumn.DataPropertyName = "КодЗаявителя";
            this.кодЗаявителяDataGridViewTextBoxColumn.DataSource = this.заявительBindingSource;
            this.кодЗаявителяDataGridViewTextBoxColumn.DisplayMember = "ФИО";
            this.кодЗаявителяDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.кодЗаявителяDataGridViewTextBoxColumn.HeaderText = "Заявитель";
            this.кодЗаявителяDataGridViewTextBoxColumn.Name = "кодЗаявителяDataGridViewTextBoxColumn";
            this.кодЗаявителяDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодЗаявителяDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодЗаявителяDataGridViewTextBoxColumn.ValueMember = "КодЗаявителя";
            // 
            // заявительBindingSource
            // 
            this.заявительBindingSource.DataMember = "Заявитель";
            this.заявительBindingSource.DataSource = this.bDDataSet;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кодОрганизацииDataGridViewTextBoxColumn
            // 
            this.кодОрганизацииDataGridViewTextBoxColumn.DataPropertyName = "КодОрганизации";
            this.кодОрганизацииDataGridViewTextBoxColumn.DataSource = this.организацияBindingSource;
            this.кодОрганизацииDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.кодОрганизацииDataGridViewTextBoxColumn.HeaderText = "Организация";
            this.кодОрганизацииDataGridViewTextBoxColumn.Name = "кодОрганизацииDataGridViewTextBoxColumn";
            this.кодОрганизацииDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодОрганизацииDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодОрганизацииDataGridViewTextBoxColumn.ValueMember = "КодОрганизации";
            this.кодОрганизацииDataGridViewTextBoxColumn.Visible = false;
            // 
            // организацияBindingSource
            // 
            this.организацияBindingSource.DataMember = "Организация";
            this.организацияBindingSource.DataSource = this.bDDataSet;
            // 
            // кодВидаЗаявкиDataGridViewTextBoxColumn
            // 
            this.кодВидаЗаявкиDataGridViewTextBoxColumn.DataPropertyName = "КодВидаЗаявки";
            this.кодВидаЗаявкиDataGridViewTextBoxColumn.DataSource = this.кодВидаЗаявкиBindingSource;
            this.кодВидаЗаявкиDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.кодВидаЗаявкиDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.кодВидаЗаявкиDataGridViewTextBoxColumn.HeaderText = "Вида обращения";
            this.кодВидаЗаявкиDataGridViewTextBoxColumn.Name = "кодВидаЗаявкиDataGridViewTextBoxColumn";
            this.кодВидаЗаявкиDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодВидаЗаявкиDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодВидаЗаявкиDataGridViewTextBoxColumn.ValueMember = "КодВидаЗаявки";
            // 
            // кодВидаЗаявкиBindingSource
            // 
            this.кодВидаЗаявкиBindingSource.DataMember = "КодВидаЗаявки";
            this.кодВидаЗаявкиBindingSource.DataSource = this.bDDataSet;
            // 
            // кодСпособаПолученияDataGridViewTextBoxColumn
            // 
            this.кодСпособаПолученияDataGridViewTextBoxColumn.DataPropertyName = "КодСпособаПолучения";
            this.кодСпособаПолученияDataGridViewTextBoxColumn.DataSource = this.способПолученияBindingSource;
            this.кодСпособаПолученияDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.кодСпособаПолученияDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.кодСпособаПолученияDataGridViewTextBoxColumn.HeaderText = "Способ получения";
            this.кодСпособаПолученияDataGridViewTextBoxColumn.Name = "кодСпособаПолученияDataGridViewTextBoxColumn";
            this.кодСпособаПолученияDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодСпособаПолученияDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодСпособаПолученияDataGridViewTextBoxColumn.ValueMember = "КодСпособа";
            // 
            // способПолученияBindingSource
            // 
            this.способПолученияBindingSource.DataMember = "СпособПолучения";
            this.способПолученияBindingSource.DataSource = this.bDDataSet;
            // 
            // комментарииDataGridViewTextBoxColumn
            // 
            this.комментарииDataGridViewTextBoxColumn.DataPropertyName = "Комментарии";
            this.комментарииDataGridViewTextBoxColumn.HeaderText = "Комментарии";
            this.комментарииDataGridViewTextBoxColumn.Name = "комментарииDataGridViewTextBoxColumn";
            // 
            // кодСотрудникаDataGridViewTextBoxColumn
            // 
            this.кодСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "КодСотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.DataSource = this.сотрудникиBindingSource;
            this.кодСотрудникаDataGridViewTextBoxColumn.DisplayMember = "ФИО";
            this.кодСотрудникаDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.кодСотрудникаDataGridViewTextBoxColumn.HeaderText = "Принял";
            this.кодСотрудникаDataGridViewTextBoxColumn.Name = "кодСотрудникаDataGridViewTextBoxColumn";
            this.кодСотрудникаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодСотрудникаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодСотрудникаDataGridViewTextBoxColumn.ValueMember = "КодСотрудника";
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.bDDataSet;
            // 
            // КомуОтправлена
            // 
            this.КомуОтправлена.DataPropertyName = "КомуОтправлена";
            this.КомуОтправлена.DataSource = this.контактныеДанныеBindingSource;
            this.КомуОтправлена.DisplayMember = "Наименование";
            this.КомуОтправлена.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.КомуОтправлена.HeaderText = "Исполнитель";
            this.КомуОтправлена.Name = "КомуОтправлена";
            this.КомуОтправлена.ValueMember = "КодКонтакта";
            // 
            // контактныеДанныеBindingSource
            // 
            this.контактныеДанныеBindingSource.DataMember = "КонтактныеДанные";
            this.контактныеДанныеBindingSource.DataSource = this.bDDataSet;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Загрузить документы";
            this.Column3.Name = "Column3";
            this.Column3.Text = "Загрузить";
            this.Column3.UseColumnTextForButtonValue = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Открыть документы";
            this.Column4.Name = "Column4";
            this.Column4.Text = "Открыть";
            this.Column4.UseColumnTextForButtonValue = true;
            // 
            // заявкаBindingSource
            // 
            this.заявкаBindingSource.DataMember = "Заявка";
            this.заявкаBindingSource.DataSource = this.bDDataSet;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.richTextBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(728, 91);
            this.panel5.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(728, 91);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator2.BindingSource = this.заявкаBindingSource;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.toolStripButton1,
            this.toolStripButton5,
            this.toolStripButton6});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 24);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(728, 25);
            this.bindingNavigator2.TabIndex = 1;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::UchZayavka.Properties.Resources.stock_save_9801;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(89, 22);
            this.toolStripButton1.Text = "Сохранить ";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::UchZayavka.Properties.Resources.print;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(133, 22);
            this.toolStripButton5.Text = "Печать обращения";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = global::UchZayavka.Properties.Resources._54308;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(164, 22);
            this.toolStripButton6.Text = "Отправить исполнителю";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(728, 21);
            this.panel4.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(364, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 21);
            this.button4.TabIndex = 3;
            this.button4.Text = "         По телефону";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(246, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 21);
            this.button3.TabIndex = 2;
            this.button3.Text = "Запрос на сайте";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(120, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "Электронная почта";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Личное обращение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.bindingNavigator1);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(734, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Клиенты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЗаявителяDataGridViewTextBoxColumn1,
            this.фИОDataGridViewTextBoxColumn,
            this.КодСтатуса,
            this.адресDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.электроннаяПочтаDataGridViewTextBoxColumn,
            this.документыDataGridViewTextBoxColumn,
            this.расширениеАрхиваDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.dataGridView1.DataSource = this.заявительBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 390);
            this.dataGridView1.TabIndex = 1;
            // 
            // кодЗаявителяDataGridViewTextBoxColumn1
            // 
            this.кодЗаявителяDataGridViewTextBoxColumn1.DataPropertyName = "КодЗаявителя";
            this.кодЗаявителяDataGridViewTextBoxColumn1.FillWeight = 5F;
            this.кодЗаявителяDataGridViewTextBoxColumn1.HeaderText = "КодЗаявителя";
            this.кодЗаявителяDataGridViewTextBoxColumn1.Name = "кодЗаявителяDataGridViewTextBoxColumn1";
            this.кодЗаявителяDataGridViewTextBoxColumn1.Visible = false;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // КодСтатуса
            // 
            this.КодСтатуса.DataPropertyName = "КодСтатуса";
            this.КодСтатуса.DataSource = this.статусЗаявителяBindingSource;
            this.КодСтатуса.DisplayMember = "Наименование";
            this.КодСтатуса.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.КодСтатуса.HeaderText = "Статус";
            this.КодСтатуса.Name = "КодСтатуса";
            this.КодСтатуса.ValueMember = "КодСтатуса";
            // 
            // статусЗаявителяBindingSource
            // 
            this.статусЗаявителяBindingSource.DataMember = "СтатусЗаявителя";
            this.статусЗаявителяBindingSource.DataSource = this.bDDataSet1;
            // 
            // bDDataSet1
            // 
            this.bDDataSet1.DataSetName = "BDDataSet";
            this.bDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес (для ответов по почте)";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // электроннаяПочтаDataGridViewTextBoxColumn
            // 
            this.электроннаяПочтаDataGridViewTextBoxColumn.DataPropertyName = "ЭлектроннаяПочта";
            this.электроннаяПочтаDataGridViewTextBoxColumn.HeaderText = "Электронная почта";
            this.электроннаяПочтаDataGridViewTextBoxColumn.Name = "электроннаяПочтаDataGridViewTextBoxColumn";
            // 
            // документыDataGridViewTextBoxColumn
            // 
            this.документыDataGridViewTextBoxColumn.DataPropertyName = "Документы";
            this.документыDataGridViewTextBoxColumn.HeaderText = "Документы";
            this.документыDataGridViewTextBoxColumn.Name = "документыDataGridViewTextBoxColumn";
            this.документыDataGridViewTextBoxColumn.Visible = false;
            // 
            // расширениеАрхиваDataGridViewTextBoxColumn
            // 
            this.расширениеАрхиваDataGridViewTextBoxColumn.DataPropertyName = "РасширениеАрхива";
            this.расширениеАрхиваDataGridViewTextBoxColumn.HeaderText = "РасширениеАрхива";
            this.расширениеАрхиваDataGridViewTextBoxColumn.Name = "расширениеАрхиваDataGridViewTextBoxColumn";
            this.расширениеАрхиваDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Загрузить документы";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Загрузить";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Открыть документы";
            this.Column2.Name = "Column2";
            this.Column2.Text = "Открыть";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // заявительBindingSource1
            // 
            this.заявительBindingSource1.DataMember = "Заявитель";
            this.заявительBindingSource1.DataSource = this.bDDataSet;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.заявительBindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(728, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::UchZayavka.Properties.Resources.stock_save_9801;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.bindingNavigator3);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(734, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Результаты обработки обращений";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодРезультатаDataGridViewTextBoxColumn,
            this.кодЗаявкиDataGridViewTextBoxColumn1,
            this.датаРассмотренияDataGridViewTextBoxColumn,
            this.ктоРассмотрелDataGridViewTextBoxColumn,
            this.кодРезультатаРассмDataGridViewTextBoxColumn,
            this.комментарииDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.результатыОбработкиBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 28);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(728, 390);
            this.dataGridView3.TabIndex = 1;
            // 
            // кодРезультатаDataGridViewTextBoxColumn
            // 
            this.кодРезультатаDataGridViewTextBoxColumn.DataPropertyName = "КодРезультата";
            this.кодРезультатаDataGridViewTextBoxColumn.FillWeight = 5F;
            this.кодРезультатаDataGridViewTextBoxColumn.HeaderText = "КодРезультата";
            this.кодРезультатаDataGridViewTextBoxColumn.Name = "кодРезультатаDataGridViewTextBoxColumn";
            this.кодРезультатаDataGridViewTextBoxColumn.Visible = false;
            // 
            // кодЗаявкиDataGridViewTextBoxColumn1
            // 
            this.кодЗаявкиDataGridViewTextBoxColumn1.DataPropertyName = "КодЗаявки";
            this.кодЗаявкиDataGridViewTextBoxColumn1.DataSource = this.заявкаBindingSource2;
            this.кодЗаявкиDataGridViewTextBoxColumn1.DisplayMember = "НомерЗаявки";
            this.кодЗаявкиDataGridViewTextBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.кодЗаявкиDataGridViewTextBoxColumn1.HeaderText = "Обращения";
            this.кодЗаявкиDataGridViewTextBoxColumn1.Name = "кодЗаявкиDataGridViewTextBoxColumn1";
            this.кодЗаявкиDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодЗаявкиDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодЗаявкиDataGridViewTextBoxColumn1.ValueMember = "КодЗаявки";
            // 
            // заявкаBindingSource2
            // 
            this.заявкаBindingSource2.DataMember = "Заявка";
            this.заявкаBindingSource2.DataSource = this.bDDataSet;
            // 
            // датаРассмотренияDataGridViewTextBoxColumn
            // 
            this.датаРассмотренияDataGridViewTextBoxColumn.DataPropertyName = "ДатаРассмотрения";
            this.датаРассмотренияDataGridViewTextBoxColumn.HeaderText = "Дата рассмотрения";
            this.датаРассмотренияDataGridViewTextBoxColumn.Name = "датаРассмотренияDataGridViewTextBoxColumn";
            // 
            // ктоРассмотрелDataGridViewTextBoxColumn
            // 
            this.ктоРассмотрелDataGridViewTextBoxColumn.DataPropertyName = "КтоРассмотрел";
            this.ктоРассмотрелDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.ктоРассмотрелDataGridViewTextBoxColumn.Name = "ктоРассмотрелDataGridViewTextBoxColumn";
            // 
            // кодРезультатаРассмDataGridViewTextBoxColumn
            // 
            this.кодРезультатаРассмDataGridViewTextBoxColumn.DataPropertyName = "КодРезультатаРассм";
            this.кодРезультатаРассмDataGridViewTextBoxColumn.DataSource = this.результатыBindingSource;
            this.кодРезультатаРассмDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.кодРезультатаРассмDataGridViewTextBoxColumn.HeaderText = "Результат";
            this.кодРезультатаРассмDataGridViewTextBoxColumn.Name = "кодРезультатаРассмDataGridViewTextBoxColumn";
            this.кодРезультатаРассмDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодРезультатаРассмDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодРезультатаРассмDataGridViewTextBoxColumn.ValueMember = "КодРезультата";
            // 
            // результатыBindingSource
            // 
            this.результатыBindingSource.DataMember = "Результаты";
            this.результатыBindingSource.DataSource = this.bDDataSet;
            // 
            // комментарииDataGridViewTextBoxColumn1
            // 
            this.комментарииDataGridViewTextBoxColumn1.DataPropertyName = "Комментарии";
            this.комментарииDataGridViewTextBoxColumn1.HeaderText = "Комментарии";
            this.комментарииDataGridViewTextBoxColumn1.Name = "комментарииDataGridViewTextBoxColumn1";
            // 
            // результатыОбработкиBindingSource
            // 
            this.результатыОбработкиBindingSource.DataMember = "РезультатыОбработки";
            this.результатыОбработкиBindingSource.DataSource = this.bDDataSet;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.bindingNavigator3.BindingSource = this.результатыОбработкиBindingSource;
            this.bindingNavigator3.CountItem = this.bindingNavigatorCountItem2;
            this.bindingNavigator3.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.bindingNavigator3.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator3.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bindingNavigator3.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bindingNavigator3.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bindingNavigator3.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.bindingNavigatorPositionItem2;
            this.bindingNavigator3.Size = new System.Drawing.Size(728, 25);
            this.bindingNavigator3.TabIndex = 0;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "Добавить";
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem2.Text = "для {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::UchZayavka.Properties.Resources.stock_save_9801;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::UchZayavka.Properties.Resources.print;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(133, 22);
            this.toolStripButton4.Text = "Печать обращения";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "24.png");
            this.imageList1.Images.SetKeyName(1, "premium-icon-user-3839635.png");
            this.imageList1.Images.SetKeyName(2, "premium-icon-check-mark-4033029.png");
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(742, 10);
            this.panel3.TabIndex = 0;
            this.panel3.Visible = false;
            // 
            // заявкаTableAdapter
            // 
            this.заявкаTableAdapter.ClearBeforeFill = true;
            // 
            // заявительTableAdapter
            // 
            this.заявительTableAdapter.ClearBeforeFill = true;
            // 
            // организацияTableAdapter
            // 
            this.организацияTableAdapter.ClearBeforeFill = true;
            // 
            // заявкаBindingSource1
            // 
            this.заявкаBindingSource1.DataMember = "Заявка";
            this.заявкаBindingSource1.DataSource = this.bDDataSet;
            // 
            // кодВидаЗаявкиTableAdapter
            // 
            this.кодВидаЗаявкиTableAdapter.ClearBeforeFill = true;
            // 
            // способПолученияTableAdapter
            // 
            this.способПолученияTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // результатыОбработкиTableAdapter
            // 
            this.результатыОбработкиTableAdapter.ClearBeforeFill = true;
            // 
            // кодВидаЗаявкиBindingSource1
            // 
            this.кодВидаЗаявкиBindingSource1.DataMember = "КодВидаЗаявки";
            this.кодВидаЗаявкиBindingSource1.DataSource = this.bDDataSet;
            // 
            // видОрганизацииBindingSource
            // 
            this.видОрганизацииBindingSource.DataMember = "ВидОрганизации";
            this.видОрганизацииBindingSource.DataSource = this.bDDataSet;
            // 
            // видОрганизацииTableAdapter
            // 
            this.видОрганизацииTableAdapter.ClearBeforeFill = true;
            // 
            // результатыTableAdapter
            // 
            this.результатыTableAdapter.ClearBeforeFill = true;
            // 
            // статусЗаявителяTableAdapter
            // 
            this.статусЗаявителяTableAdapter.ClearBeforeFill = true;
            // 
            // контактныеДанныеTableAdapter
            // 
            this.контактныеДанныеTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Учет работы с клиентами ООО «Организационно-технологические решения 2000» ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кодВидаЗаявкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.способПолученияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактныеДанныеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусЗаявителяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявительBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.результатыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.результатыОбработкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кодВидаЗаявкиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видОрганизацииBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem организацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыОбработкиToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource заявкаBindingSource;
        private BDDataSetTableAdapters.ЗаявкаTableAdapter заявкаTableAdapter;
        private System.Windows.Forms.BindingSource заявительBindingSource;
        private BDDataSetTableAdapters.ЗаявительTableAdapter заявительTableAdapter;
        private System.Windows.Forms.BindingSource организацияBindingSource;
        private BDDataSetTableAdapters.ОрганизацияTableAdapter организацияTableAdapter;
        private System.Windows.Forms.BindingSource заявкаBindingSource1;
        private System.Windows.Forms.BindingSource кодВидаЗаявкиBindingSource;
        private BDDataSetTableAdapters.КодВидаЗаявкиTableAdapter кодВидаЗаявкиTableAdapter;
        private System.Windows.Forms.BindingSource способПолученияBindingSource;
        private BDDataSetTableAdapters.СпособПолученияTableAdapter способПолученияTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private BDDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource заявительBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.BindingSource результатыОбработкиBindingSource;
        private BDDataSetTableAdapters.РезультатыОбработкиTableAdapter результатыОбработкиTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource заявкаBindingSource2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.BindingSource кодВидаЗаявкиBindingSource1;
        private System.Windows.Forms.BindingSource видОрганизацииBindingSource;
        private BDDataSetTableAdapters.ВидОрганизацииTableAdapter видОрганизацииTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem списокЗаявокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЗаявителейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыОбработкиЗаявокToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.BindingSource результатыBindingSource;
        private BDDataSetTableAdapters.РезультатыTableAdapter результатыTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem статистикаПриемаЗаявокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бланкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бланкОтчетаПоЗаявкеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бланкШаблонаОтчетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripMenuItem видыОрганизацийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыЗаявокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусыЗаявителейToolStripMenuItem;
        private BDDataSet bDDataSet1;
        private System.Windows.Forms.BindingSource статусЗаявителяBindingSource;
        private BDDataSetTableAdapters.СтатусЗаявителяTableAdapter статусЗаявителяTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem статистикаЗаявокПоСтатусамЗаявителейИВидамЗаявокToolStripMenuItem;
        private System.Windows.Forms.BindingSource контактныеДанныеBindingSource;
        private BDDataSetTableAdapters.КонтактныеДанныеTableAdapter контактныеДанныеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЗаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодЗаявителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодОрганизацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодВидаЗаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодСпособаПолученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn комментарииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn КомуОтправлена;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЗаявителяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn КодСтатуса;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn электроннаяПочтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn документыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расширениеАрхиваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРезультатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодЗаявкиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРассмотренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ктоРассмотрелDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодРезультатаРассмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn комментарииDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

