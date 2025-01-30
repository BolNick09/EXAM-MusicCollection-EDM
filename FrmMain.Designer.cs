namespace EXAM_MusicCollection_EDM
{
    partial class FrmMain
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
            this.tbpMain = new System.Windows.Forms.TabControl();
            this.tbpRecord = new System.Windows.Forms.TabPage();
            this.gbRecord = new System.Windows.Forms.GroupBox();
            this.chkRecordOnSale = new System.Windows.Forms.CheckBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.cbbRecordGenre = new System.Windows.Forms.ComboBox();
            this.cbbRecordGroup = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRecordStockCount = new System.Windows.Forms.TextBox();
            this.tbRecordSalePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRecordTrackCount = new System.Windows.Forms.TextBox();
            this.tbRecordCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRecordYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRecordPublisher = new System.Windows.Forms.TextBox();
            this.tbRecordName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpArtist = new System.Windows.Forms.TabPage();
            this.tbArtistName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbpGenre = new System.Windows.Forms.TabPage();
            this.tbGenreName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbpUser = new System.Windows.Forms.TabPage();
            this.chkUserAdmin = new System.Windows.Forms.CheckBox();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbpMain.SuspendLayout();
            this.tbpRecord.SuspendLayout();
            this.gbRecord.SuspendLayout();
            this.tbpArtist.SuspendLayout();
            this.tbpGenre.SuspendLayout();
            this.tbpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpMain
            // 
            this.tbpMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbpMain.Controls.Add(this.tbpRecord);
            this.tbpMain.Controls.Add(this.tbpArtist);
            this.tbpMain.Controls.Add(this.tbpGenre);
            this.tbpMain.Controls.Add(this.tbpUser);
            this.tbpMain.Location = new System.Drawing.Point(12, 12);
            this.tbpMain.Name = "tbpMain";
            this.tbpMain.SelectedIndex = 0;
            this.tbpMain.Size = new System.Drawing.Size(434, 393);
            this.tbpMain.TabIndex = 0;
            this.tbpMain.SelectedIndexChanged += new System.EventHandler(this.tbpMain_SelectedIndexChanged);
            this.tbpMain.TabIndexChanged += new System.EventHandler(this.tbpMain_TabIndexChanged);
            // 
            // tbpRecord
            // 
            this.tbpRecord.Controls.Add(this.gbRecord);
            this.tbpRecord.Location = new System.Drawing.Point(4, 25);
            this.tbpRecord.Name = "tbpRecord";
            this.tbpRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRecord.Size = new System.Drawing.Size(426, 364);
            this.tbpRecord.TabIndex = 0;
            this.tbpRecord.Text = "Запись";
            this.tbpRecord.UseVisualStyleBackColor = true;
            // 
            // gbRecord
            // 
            this.gbRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRecord.Controls.Add(this.chkRecordOnSale);
            this.gbRecord.Controls.Add(this.btnSell);
            this.gbRecord.Controls.Add(this.cbbRecordGenre);
            this.gbRecord.Controls.Add(this.cbbRecordGroup);
            this.gbRecord.Controls.Add(this.label9);
            this.gbRecord.Controls.Add(this.label8);
            this.gbRecord.Controls.Add(this.tbRecordStockCount);
            this.gbRecord.Controls.Add(this.tbRecordSalePrice);
            this.gbRecord.Controls.Add(this.label5);
            this.gbRecord.Controls.Add(this.tbRecordTrackCount);
            this.gbRecord.Controls.Add(this.tbRecordCost);
            this.gbRecord.Controls.Add(this.label7);
            this.gbRecord.Controls.Add(this.tbRecordYear);
            this.gbRecord.Controls.Add(this.label6);
            this.gbRecord.Controls.Add(this.tbRecordPublisher);
            this.gbRecord.Controls.Add(this.tbRecordName);
            this.gbRecord.Controls.Add(this.label4);
            this.gbRecord.Controls.Add(this.label3);
            this.gbRecord.Controls.Add(this.label2);
            this.gbRecord.Controls.Add(this.label1);
            this.gbRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbRecord.Location = new System.Drawing.Point(6, 6);
            this.gbRecord.Name = "gbRecord";
            this.gbRecord.Size = new System.Drawing.Size(409, 349);
            this.gbRecord.TabIndex = 1;
            this.gbRecord.TabStop = false;
            this.gbRecord.Text = "Параметры записи";
            // 
            // chkRecordOnSale
            // 
            this.chkRecordOnSale.AutoSize = true;
            this.chkRecordOnSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkRecordOnSale.Location = new System.Drawing.Point(10, 285);
            this.chkRecordOnSale.Name = "chkRecordOnSale";
            this.chkRecordOnSale.Size = new System.Drawing.Size(74, 24);
            this.chkRecordOnSale.TabIndex = 46;
            this.chkRecordOnSale.Text = "Акция";
            this.chkRecordOnSale.UseVisualStyleBackColor = true;
            // 
            // btnSell
            // 
            this.btnSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSell.Location = new System.Drawing.Point(305, 300);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(97, 32);
            this.btnSell.TabIndex = 45;
            this.btnSell.Text = "Продать";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // cbbRecordGenre
            // 
            this.cbbRecordGenre.FormattingEnabled = true;
            this.cbbRecordGenre.Location = new System.Drawing.Point(216, 147);
            this.cbbRecordGenre.Name = "cbbRecordGenre";
            this.cbbRecordGenre.Size = new System.Drawing.Size(186, 28);
            this.cbbRecordGenre.TabIndex = 42;
            // 
            // cbbRecordGroup
            // 
            this.cbbRecordGroup.FormattingEnabled = true;
            this.cbbRecordGroup.Location = new System.Drawing.Point(216, 60);
            this.cbbRecordGroup.Name = "cbbRecordGroup";
            this.cbbRecordGroup.Size = new System.Drawing.Size(186, 28);
            this.cbbRecordGroup.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Количество на складе:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Цена для продажи:";
            // 
            // tbRecordStockCount
            // 
            this.tbRecordStockCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRecordStockCount.Location = new System.Drawing.Point(216, 260);
            this.tbRecordStockCount.Name = "tbRecordStockCount";
            this.tbRecordStockCount.Size = new System.Drawing.Size(186, 24);
            this.tbRecordStockCount.TabIndex = 35;
            // 
            // tbRecordSalePrice
            // 
            this.tbRecordSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRecordSalePrice.Location = new System.Drawing.Point(216, 232);
            this.tbRecordSalePrice.Name = "tbRecordSalePrice";
            this.tbRecordSalePrice.Size = new System.Drawing.Size(186, 24);
            this.tbRecordSalePrice.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Себестоимость:";
            // 
            // tbRecordTrackCount
            // 
            this.tbRecordTrackCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRecordTrackCount.Location = new System.Drawing.Point(216, 120);
            this.tbRecordTrackCount.Name = "tbRecordTrackCount";
            this.tbRecordTrackCount.Size = new System.Drawing.Size(186, 24);
            this.tbRecordTrackCount.TabIndex = 32;
            // 
            // tbRecordCost
            // 
            this.tbRecordCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRecordCost.Location = new System.Drawing.Point(216, 204);
            this.tbRecordCost.Name = "tbRecordCost";
            this.tbRecordCost.Size = new System.Drawing.Size(186, 24);
            this.tbRecordCost.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(5, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Год издания:";
            // 
            // tbRecordYear
            // 
            this.tbRecordYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRecordYear.Location = new System.Drawing.Point(216, 176);
            this.tbRecordYear.Name = "tbRecordYear";
            this.tbRecordYear.Size = new System.Drawing.Size(186, 24);
            this.tbRecordYear.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Жанр:";
            // 
            // tbRecordPublisher
            // 
            this.tbRecordPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRecordPublisher.Location = new System.Drawing.Point(216, 92);
            this.tbRecordPublisher.Name = "tbRecordPublisher";
            this.tbRecordPublisher.Size = new System.Drawing.Size(186, 24);
            this.tbRecordPublisher.TabIndex = 26;
            // 
            // tbRecordName
            // 
            this.tbRecordName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRecordName.Location = new System.Drawing.Point(216, 27);
            this.tbRecordName.Name = "tbRecordName";
            this.tbRecordName.Size = new System.Drawing.Size(186, 27);
            this.tbRecordName.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Количество треков:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Название издателя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Название коллектива:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Название пластинки:";
            // 
            // tbpArtist
            // 
            this.tbpArtist.Controls.Add(this.tbArtistName);
            this.tbpArtist.Controls.Add(this.label10);
            this.tbpArtist.Location = new System.Drawing.Point(4, 25);
            this.tbpArtist.Name = "tbpArtist";
            this.tbpArtist.Padding = new System.Windows.Forms.Padding(3);
            this.tbpArtist.Size = new System.Drawing.Size(426, 364);
            this.tbpArtist.TabIndex = 1;
            this.tbpArtist.Text = "Исполнитель";
            this.tbpArtist.UseVisualStyleBackColor = true;
            // 
            // tbArtistName
            // 
            this.tbArtistName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbArtistName.Location = new System.Drawing.Point(156, 20);
            this.tbArtistName.Name = "tbArtistName";
            this.tbArtistName.Size = new System.Drawing.Size(255, 27);
            this.tbArtistName.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(15, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Название группы:";
            // 
            // tbpGenre
            // 
            this.tbpGenre.Controls.Add(this.tbGenreName);
            this.tbpGenre.Controls.Add(this.label11);
            this.tbpGenre.Location = new System.Drawing.Point(4, 25);
            this.tbpGenre.Name = "tbpGenre";
            this.tbpGenre.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGenre.Size = new System.Drawing.Size(426, 364);
            this.tbpGenre.TabIndex = 2;
            this.tbpGenre.Text = "Жанр";
            this.tbpGenre.UseVisualStyleBackColor = true;
            // 
            // tbGenreName
            // 
            this.tbGenreName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGenreName.Location = new System.Drawing.Point(216, 14);
            this.tbGenreName.Name = "tbGenreName";
            this.tbGenreName.Size = new System.Drawing.Size(186, 27);
            this.tbGenreName.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Название жанра:";
            // 
            // tbpUser
            // 
            this.tbpUser.Controls.Add(this.chkUserAdmin);
            this.tbpUser.Controls.Add(this.tbUserPassword);
            this.tbpUser.Controls.Add(this.label13);
            this.tbpUser.Controls.Add(this.tbUserName);
            this.tbpUser.Controls.Add(this.label12);
            this.tbpUser.Location = new System.Drawing.Point(4, 25);
            this.tbpUser.Name = "tbpUser";
            this.tbpUser.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUser.Size = new System.Drawing.Size(426, 364);
            this.tbpUser.TabIndex = 3;
            this.tbpUser.Text = "Пользователь";
            this.tbpUser.UseVisualStyleBackColor = true;
            // 
            // chkUserAdmin
            // 
            this.chkUserAdmin.AutoSize = true;
            this.chkUserAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkUserAdmin.Location = new System.Drawing.Point(6, 84);
            this.chkUserAdmin.Name = "chkUserAdmin";
            this.chkUserAdmin.Size = new System.Drawing.Size(195, 24);
            this.chkUserAdmin.TabIndex = 47;
            this.chkUserAdmin.Text = "Права администратора";
            this.chkUserAdmin.UseVisualStyleBackColor = true;
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserPassword.Location = new System.Drawing.Point(216, 44);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.Size = new System.Drawing.Size(186, 27);
            this.tbUserPassword.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Пароль пользователя:";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserName.Location = new System.Drawing.Point(216, 11);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(186, 27);
            this.tbUserName.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Имя пользователя:";
            // 
            // dgvMain
            // 
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(452, 70);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.Size = new System.Drawing.Size(508, 373);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDel.Location = new System.Drawing.Point(345, 411);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(97, 32);
            this.btnDel.TabIndex = 43;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnMod
            // 
            this.btnMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMod.Location = new System.Drawing.Point(242, 411);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(97, 32);
            this.btnMod.TabIndex = 42;
            this.btnMod.Text = "Изменить";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(139, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 32);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(16, 411);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 32);
            this.btnRefresh.TabIndex = 44;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbbSearch
            // 
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Items.AddRange(new object[] {
            "Поназванию диска",
            "По исполнителю",
            "По жанру"});
            this.cbbSearch.Location = new System.Drawing.Point(736, 35);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(121, 24);
            this.cbbSearch.TabIndex = 45;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(863, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 32);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(452, 32);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(278, 27);
            this.tbSearch.TabIndex = 47;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 453);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbbSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.tbpMain);
            this.MinimumSize = new System.Drawing.Size(990, 500);
            this.Name = "FrmMain";
            this.Text = "Музыкальный магазин";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tbpMain.ResumeLayout(false);
            this.tbpRecord.ResumeLayout(false);
            this.gbRecord.ResumeLayout(false);
            this.gbRecord.PerformLayout();
            this.tbpArtist.ResumeLayout(false);
            this.tbpArtist.PerformLayout();
            this.tbpGenre.ResumeLayout(false);
            this.tbpGenre.PerformLayout();
            this.tbpUser.ResumeLayout(false);
            this.tbpUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbpMain;
        private System.Windows.Forms.TabPage tbpRecord;
        private System.Windows.Forms.GroupBox gbRecord;
        private System.Windows.Forms.ComboBox cbbRecordGenre;
        private System.Windows.Forms.ComboBox cbbRecordGroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbRecordStockCount;
        private System.Windows.Forms.TextBox tbRecordSalePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRecordTrackCount;
        private System.Windows.Forms.TextBox tbRecordCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRecordYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRecordPublisher;
        private System.Windows.Forms.TextBox tbRecordName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbpArtist;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tbpGenre;
        private System.Windows.Forms.TabPage tbpUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.CheckBox chkRecordOnSale;
        private System.Windows.Forms.TextBox tbArtistName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbGenreName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkUserAdmin;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
    }
}

