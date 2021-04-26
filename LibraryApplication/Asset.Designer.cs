
namespace LibraryProject
{
    partial class Asset
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
            this.uxTypeLabel = new System.Windows.Forms.Label();
            this.uxAddRelDateLabel = new System.Windows.Forms.Label();
            this.uxAddAssetButton = new System.Windows.Forms.Button();
            this.uxAddNameLabel = new System.Windows.Forms.Label();
            this.uxAddNameTextBox = new System.Windows.Forms.TextBox();
            this.uxAddCreatorLabel = new System.Windows.Forms.Label();
            this.uxAddCategoriesLabel = new System.Windows.Forms.Label();
            this.uxAddTypeDDL = new System.Windows.Forms.ComboBox();
            this.uxAddDate = new System.Windows.Forms.DateTimePicker();
            this.uxAddFNameLabel = new System.Windows.Forms.Label();
            this.uxAddLNameLabel = new System.Windows.Forms.Label();
            this.uxAddCompanyLabel = new System.Windows.Forms.Label();
            this.uxAddFNameTextBox = new System.Windows.Forms.TextBox();
            this.uxAddLNameTextBox = new System.Windows.Forms.TextBox();
            this.uxAddCompanyTextBox = new System.Windows.Forms.TextBox();
            this.uxAddFantasy = new System.Windows.Forms.CheckBox();
            this.uxAddRomance = new System.Windows.Forms.CheckBox();
            this.uxAddMystery = new System.Windows.Forms.CheckBox();
            this.uxAddHorror = new System.Windows.Forms.CheckBox();
            this.uxAddMemoir = new System.Windows.Forms.CheckBox();
            this.uxAddCooking = new System.Windows.Forms.CheckBox();
            this.uxAddHealth = new System.Windows.Forms.CheckBox();
            this.uxAddHistory = new System.Windows.Forms.CheckBox();
            this.uxAddTravel = new System.Windows.Forms.CheckBox();
            this.uxAddHumor = new System.Windows.Forms.CheckBox();
            this.uxAddMMO = new System.Windows.Forms.CheckBox();
            this.uxAddSport = new System.Windows.Forms.CheckBox();
            this.uxAddSimulation = new System.Windows.Forms.CheckBox();
            this.uxAddRPG = new System.Windows.Forms.CheckBox();
            this.uxAddAction = new System.Windows.Forms.CheckBox();
            this.uxAddAdventure = new System.Windows.Forms.CheckBox();
            this.uxAddChildren = new System.Windows.Forms.CheckBox();
            this.uxLine4 = new System.Windows.Forms.Label();
            this.uxLine5 = new System.Windows.Forms.Label();
            this.uxAssetAssetIDLabel = new System.Windows.Forms.Label();
            this.uxAssetAssetIDTextBox = new System.Windows.Forms.TextBox();
            this.uxFetchSituationOfAssetButton = new System.Windows.Forms.Button();
            this.uxGetPossibleAssetsButton = new System.Windows.Forms.Button();
            this.uxAssetAssetNameLabel = new System.Windows.Forms.Label();
            this.uxAssetAssetNameTextBox = new System.Windows.Forms.TextBox();
            this.uxFetchCheckoutHistoryButton = new System.Windows.Forms.Button();
            this.uxAssetUserIDLabel = new System.Windows.Forms.Label();
            this.uxAssetUserIDTextBox = new System.Windows.Forms.TextBox();
            this.uxFetchCheckoutHistoryGridView = new System.Windows.Forms.DataGridView();
            this.uxFetchSituationOfAssetGridView = new System.Windows.Forms.DataGridView();
            this.uxGetPossibleAssetsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxFetchCheckoutHistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxFetchSituationOfAssetGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGetPossibleAssetsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxTypeLabel
            // 
            this.uxTypeLabel.AutoSize = true;
            this.uxTypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxTypeLabel.Location = new System.Drawing.Point(165, 128);
            this.uxTypeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxTypeLabel.Name = "uxTypeLabel";
            this.uxTypeLabel.Size = new System.Drawing.Size(115, 54);
            this.uxTypeLabel.TabIndex = 13;
            this.uxTypeLabel.Text = "Type:";
            // 
            // uxAddRelDateLabel
            // 
            this.uxAddRelDateLabel.AutoSize = true;
            this.uxAddRelDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddRelDateLabel.Location = new System.Drawing.Point(41, 238);
            this.uxAddRelDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxAddRelDateLabel.Name = "uxAddRelDateLabel";
            this.uxAddRelDateLabel.Size = new System.Drawing.Size(259, 54);
            this.uxAddRelDateLabel.TabIndex = 10;
            this.uxAddRelDateLabel.Text = "Release Date:";
            // 
            // uxAddAssetButton
            // 
            this.uxAddAssetButton.Location = new System.Drawing.Point(500, 948);
            this.uxAddAssetButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddAssetButton.Name = "uxAddAssetButton";
            this.uxAddAssetButton.Size = new System.Drawing.Size(432, 139);
            this.uxAddAssetButton.TabIndex = 9;
            this.uxAddAssetButton.Text = "Insert Asset";
            this.uxAddAssetButton.UseVisualStyleBackColor = true;
            this.uxAddAssetButton.Click += new System.EventHandler(this.uxAddAssetButton_Click);
            // 
            // uxAddNameLabel
            // 
            this.uxAddNameLabel.AutoSize = true;
            this.uxAddNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddNameLabel.Location = new System.Drawing.Point(138, 33);
            this.uxAddNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxAddNameLabel.Name = "uxAddNameLabel";
            this.uxAddNameLabel.Size = new System.Drawing.Size(137, 54);
            this.uxAddNameLabel.TabIndex = 8;
            this.uxAddNameLabel.Text = "Name:";
            // 
            // uxAddNameTextBox
            // 
            this.uxAddNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddNameTextBox.Location = new System.Drawing.Point(406, 33);
            this.uxAddNameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddNameTextBox.Name = "uxAddNameTextBox";
            this.uxAddNameTextBox.Size = new System.Drawing.Size(730, 61);
            this.uxAddNameTextBox.TabIndex = 7;
            // 
            // uxAddCreatorLabel
            // 
            this.uxAddCreatorLabel.AutoSize = true;
            this.uxAddCreatorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddCreatorLabel.Location = new System.Drawing.Point(114, 313);
            this.uxAddCreatorLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxAddCreatorLabel.Name = "uxAddCreatorLabel";
            this.uxAddCreatorLabel.Size = new System.Drawing.Size(163, 54);
            this.uxAddCreatorLabel.TabIndex = 14;
            this.uxAddCreatorLabel.Text = "Creator:";
            // 
            // uxAddCategoriesLabel
            // 
            this.uxAddCategoriesLabel.AutoSize = true;
            this.uxAddCategoriesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddCategoriesLabel.Location = new System.Drawing.Point(71, 640);
            this.uxAddCategoriesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxAddCategoriesLabel.Name = "uxAddCategoriesLabel";
            this.uxAddCategoriesLabel.Size = new System.Drawing.Size(221, 54);
            this.uxAddCategoriesLabel.TabIndex = 15;
            this.uxAddCategoriesLabel.Text = "Categories:";
            // 
            // uxAddTypeDDL
            // 
            this.uxAddTypeDDL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddTypeDDL.FormattingEnabled = true;
            this.uxAddTypeDDL.Location = new System.Drawing.Point(408, 128);
            this.uxAddTypeDDL.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddTypeDDL.Name = "uxAddTypeDDL";
            this.uxAddTypeDDL.Size = new System.Drawing.Size(733, 62);
            this.uxAddTypeDDL.TabIndex = 16;
            // 
            // uxAddDate
            // 
            this.uxAddDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddDate.Location = new System.Drawing.Point(406, 238);
            this.uxAddDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddDate.Name = "uxAddDate";
            this.uxAddDate.Size = new System.Drawing.Size(733, 61);
            this.uxAddDate.TabIndex = 17;
            // 
            // uxAddFNameLabel
            // 
            this.uxAddFNameLabel.AutoSize = true;
            this.uxAddFNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddFNameLabel.Location = new System.Drawing.Point(262, 374);
            this.uxAddFNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxAddFNameLabel.Name = "uxAddFNameLabel";
            this.uxAddFNameLabel.Size = new System.Drawing.Size(223, 54);
            this.uxAddFNameLabel.TabIndex = 18;
            this.uxAddFNameLabel.Text = "First Name:";
            // 
            // uxAddLNameLabel
            // 
            this.uxAddLNameLabel.AutoSize = true;
            this.uxAddLNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddLNameLabel.Location = new System.Drawing.Point(267, 462);
            this.uxAddLNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxAddLNameLabel.Name = "uxAddLNameLabel";
            this.uxAddLNameLabel.Size = new System.Drawing.Size(218, 54);
            this.uxAddLNameLabel.TabIndex = 19;
            this.uxAddLNameLabel.Text = "Last Name:";
            // 
            // uxAddCompanyLabel
            // 
            this.uxAddCompanyLabel.AutoSize = true;
            this.uxAddCompanyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddCompanyLabel.Location = new System.Drawing.Point(284, 548);
            this.uxAddCompanyLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxAddCompanyLabel.Name = "uxAddCompanyLabel";
            this.uxAddCompanyLabel.Size = new System.Drawing.Size(200, 54);
            this.uxAddCompanyLabel.TabIndex = 20;
            this.uxAddCompanyLabel.Text = "Company:";
            // 
            // uxAddFNameTextBox
            // 
            this.uxAddFNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddFNameTextBox.Location = new System.Drawing.Point(500, 369);
            this.uxAddFNameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddFNameTextBox.Name = "uxAddFNameTextBox";
            this.uxAddFNameTextBox.Size = new System.Drawing.Size(636, 61);
            this.uxAddFNameTextBox.TabIndex = 21;
            // 
            // uxAddLNameTextBox
            // 
            this.uxAddLNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddLNameTextBox.Location = new System.Drawing.Point(500, 462);
            this.uxAddLNameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddLNameTextBox.Name = "uxAddLNameTextBox";
            this.uxAddLNameTextBox.Size = new System.Drawing.Size(636, 61);
            this.uxAddLNameTextBox.TabIndex = 22;
            // 
            // uxAddCompanyTextBox
            // 
            this.uxAddCompanyTextBox.Enabled = false;
            this.uxAddCompanyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddCompanyTextBox.Location = new System.Drawing.Point(500, 548);
            this.uxAddCompanyTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddCompanyTextBox.Name = "uxAddCompanyTextBox";
            this.uxAddCompanyTextBox.Size = new System.Drawing.Size(636, 61);
            this.uxAddCompanyTextBox.TabIndex = 23;
            // 
            // uxAddFantasy
            // 
            this.uxAddFantasy.AutoSize = true;
            this.uxAddFantasy.Location = new System.Drawing.Point(376, 648);
            this.uxAddFantasy.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddFantasy.Name = "uxAddFantasy";
            this.uxAddFantasy.Size = new System.Drawing.Size(155, 45);
            this.uxAddFantasy.TabIndex = 24;
            this.uxAddFantasy.Text = "Fantasy";
            this.uxAddFantasy.UseVisualStyleBackColor = true;
            // 
            // uxAddRomance
            // 
            this.uxAddRomance.AutoSize = true;
            this.uxAddRomance.Location = new System.Drawing.Point(571, 648);
            this.uxAddRomance.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddRomance.Name = "uxAddRomance";
            this.uxAddRomance.Size = new System.Drawing.Size(179, 45);
            this.uxAddRomance.TabIndex = 25;
            this.uxAddRomance.Text = "Romance";
            this.uxAddRomance.UseVisualStyleBackColor = true;
            // 
            // uxAddMystery
            // 
            this.uxAddMystery.AutoSize = true;
            this.uxAddMystery.Location = new System.Drawing.Point(792, 648);
            this.uxAddMystery.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddMystery.Name = "uxAddMystery";
            this.uxAddMystery.Size = new System.Drawing.Size(162, 45);
            this.uxAddMystery.TabIndex = 26;
            this.uxAddMystery.Text = "Mystery";
            this.uxAddMystery.UseVisualStyleBackColor = true;
            // 
            // uxAddHorror
            // 
            this.uxAddHorror.AutoSize = true;
            this.uxAddHorror.Location = new System.Drawing.Point(988, 648);
            this.uxAddHorror.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddHorror.Name = "uxAddHorror";
            this.uxAddHorror.Size = new System.Drawing.Size(143, 45);
            this.uxAddHorror.TabIndex = 27;
            this.uxAddHorror.Text = "Horror";
            this.uxAddHorror.UseVisualStyleBackColor = true;
            // 
            // uxAddMemoir
            // 
            this.uxAddMemoir.AutoSize = true;
            this.uxAddMemoir.Location = new System.Drawing.Point(376, 702);
            this.uxAddMemoir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddMemoir.Name = "uxAddMemoir";
            this.uxAddMemoir.Size = new System.Drawing.Size(160, 45);
            this.uxAddMemoir.TabIndex = 28;
            this.uxAddMemoir.Text = "Memoir";
            this.uxAddMemoir.UseVisualStyleBackColor = true;
            // 
            // uxAddCooking
            // 
            this.uxAddCooking.AutoSize = true;
            this.uxAddCooking.Location = new System.Drawing.Point(571, 702);
            this.uxAddCooking.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddCooking.Name = "uxAddCooking";
            this.uxAddCooking.Size = new System.Drawing.Size(168, 45);
            this.uxAddCooking.TabIndex = 29;
            this.uxAddCooking.Text = "Cooking";
            this.uxAddCooking.UseVisualStyleBackColor = true;
            // 
            // uxAddHealth
            // 
            this.uxAddHealth.AutoSize = true;
            this.uxAddHealth.Location = new System.Drawing.Point(792, 702);
            this.uxAddHealth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddHealth.Name = "uxAddHealth";
            this.uxAddHealth.Size = new System.Drawing.Size(142, 45);
            this.uxAddHealth.TabIndex = 30;
            this.uxAddHealth.Text = "Health";
            this.uxAddHealth.UseVisualStyleBackColor = true;
            // 
            // uxAddHistory
            // 
            this.uxAddHistory.AutoSize = true;
            this.uxAddHistory.Location = new System.Drawing.Point(988, 702);
            this.uxAddHistory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddHistory.Name = "uxAddHistory";
            this.uxAddHistory.Size = new System.Drawing.Size(150, 45);
            this.uxAddHistory.TabIndex = 31;
            this.uxAddHistory.Text = "History";
            this.uxAddHistory.UseVisualStyleBackColor = true;
            // 
            // uxAddTravel
            // 
            this.uxAddTravel.AutoSize = true;
            this.uxAddTravel.Location = new System.Drawing.Point(376, 759);
            this.uxAddTravel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddTravel.Name = "uxAddTravel";
            this.uxAddTravel.Size = new System.Drawing.Size(131, 45);
            this.uxAddTravel.TabIndex = 32;
            this.uxAddTravel.Text = "Travel";
            this.uxAddTravel.UseVisualStyleBackColor = true;
            // 
            // uxAddHumor
            // 
            this.uxAddHumor.AutoSize = true;
            this.uxAddHumor.Location = new System.Drawing.Point(571, 759);
            this.uxAddHumor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddHumor.Name = "uxAddHumor";
            this.uxAddHumor.Size = new System.Drawing.Size(148, 45);
            this.uxAddHumor.TabIndex = 33;
            this.uxAddHumor.Text = "Humor";
            this.uxAddHumor.UseVisualStyleBackColor = true;
            // 
            // uxAddMMO
            // 
            this.uxAddMMO.AutoSize = true;
            this.uxAddMMO.Location = new System.Drawing.Point(648, 874);
            this.uxAddMMO.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddMMO.Name = "uxAddMMO";
            this.uxAddMMO.Size = new System.Drawing.Size(133, 45);
            this.uxAddMMO.TabIndex = 34;
            this.uxAddMMO.Text = "MMO";
            this.uxAddMMO.UseVisualStyleBackColor = true;
            // 
            // uxAddSport
            // 
            this.uxAddSport.AutoSize = true;
            this.uxAddSport.Location = new System.Drawing.Point(792, 817);
            this.uxAddSport.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddSport.Name = "uxAddSport";
            this.uxAddSport.Size = new System.Drawing.Size(128, 45);
            this.uxAddSport.TabIndex = 35;
            this.uxAddSport.Text = "Sport";
            this.uxAddSport.UseVisualStyleBackColor = true;
            // 
            // uxAddSimulation
            // 
            this.uxAddSimulation.AutoSize = true;
            this.uxAddSimulation.Location = new System.Drawing.Point(988, 817);
            this.uxAddSimulation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddSimulation.Name = "uxAddSimulation";
            this.uxAddSimulation.Size = new System.Drawing.Size(196, 45);
            this.uxAddSimulation.TabIndex = 36;
            this.uxAddSimulation.Text = "Simulation";
            this.uxAddSimulation.UseVisualStyleBackColor = true;
            // 
            // uxAddRPG
            // 
            this.uxAddRPG.AutoSize = true;
            this.uxAddRPG.Location = new System.Drawing.Point(571, 817);
            this.uxAddRPG.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddRPG.Name = "uxAddRPG";
            this.uxAddRPG.Size = new System.Drawing.Size(112, 45);
            this.uxAddRPG.TabIndex = 37;
            this.uxAddRPG.Text = "RPG";
            this.uxAddRPG.UseVisualStyleBackColor = true;
            // 
            // uxAddAction
            // 
            this.uxAddAction.AutoSize = true;
            this.uxAddAction.Location = new System.Drawing.Point(376, 817);
            this.uxAddAction.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddAction.Name = "uxAddAction";
            this.uxAddAction.Size = new System.Drawing.Size(141, 45);
            this.uxAddAction.TabIndex = 38;
            this.uxAddAction.Text = "Action";
            this.uxAddAction.UseVisualStyleBackColor = true;
            // 
            // uxAddAdventure
            // 
            this.uxAddAdventure.AutoSize = true;
            this.uxAddAdventure.Location = new System.Drawing.Point(988, 759);
            this.uxAddAdventure.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddAdventure.Name = "uxAddAdventure";
            this.uxAddAdventure.Size = new System.Drawing.Size(193, 45);
            this.uxAddAdventure.TabIndex = 39;
            this.uxAddAdventure.Text = "Adventure";
            this.uxAddAdventure.UseVisualStyleBackColor = true;
            // 
            // uxAddChildren
            // 
            this.uxAddChildren.AutoSize = true;
            this.uxAddChildren.Location = new System.Drawing.Point(792, 759);
            this.uxAddChildren.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAddChildren.Name = "uxAddChildren";
            this.uxAddChildren.Size = new System.Drawing.Size(167, 45);
            this.uxAddChildren.TabIndex = 40;
            this.uxAddChildren.Text = "Children";
            this.uxAddChildren.UseVisualStyleBackColor = true;
            // 
            // uxLine4
            // 
            this.uxLine4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine4.Location = new System.Drawing.Point(136, 1130);
            this.uxLine4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxLine4.Name = "uxLine4";
            this.uxLine4.Size = new System.Drawing.Size(2421, 3);
            this.uxLine4.TabIndex = 41;
            this.uxLine4.Text = "                             ";
            // 
            // uxLine5
            // 
            this.uxLine5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine5.Location = new System.Drawing.Point(1331, 77);
            this.uxLine5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxLine5.Name = "uxLine5";
            this.uxLine5.Size = new System.Drawing.Size(3, 2132);
            this.uxLine5.TabIndex = 42;
            this.uxLine5.Text = "                             ";
            // 
            // uxAssetAssetIDLabel
            // 
            this.uxAssetAssetIDLabel.AutoSize = true;
            this.uxAssetAssetIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAssetAssetIDLabel.Location = new System.Drawing.Point(182, 1225);
            this.uxAssetAssetIDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxAssetAssetIDLabel.Name = "uxAssetAssetIDLabel";
            this.uxAssetAssetIDLabel.Size = new System.Drawing.Size(166, 54);
            this.uxAssetAssetIDLabel.TabIndex = 44;
            this.uxAssetAssetIDLabel.Text = "AssetID:";
            // 
            // uxAssetAssetIDTextBox
            // 
            this.uxAssetAssetIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAssetAssetIDTextBox.Location = new System.Drawing.Point(394, 1225);
            this.uxAssetAssetIDTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAssetAssetIDTextBox.Name = "uxAssetAssetIDTextBox";
            this.uxAssetAssetIDTextBox.Size = new System.Drawing.Size(733, 61);
            this.uxAssetAssetIDTextBox.TabIndex = 43;
            // 
            // uxFetchSituationOfAssetButton
            // 
            this.uxFetchSituationOfAssetButton.Location = new System.Drawing.Point(500, 1323);
            this.uxFetchSituationOfAssetButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxFetchSituationOfAssetButton.Name = "uxFetchSituationOfAssetButton";
            this.uxFetchSituationOfAssetButton.Size = new System.Drawing.Size(432, 139);
            this.uxFetchSituationOfAssetButton.TabIndex = 45;
            this.uxFetchSituationOfAssetButton.Text = "Fetch Situation of Asset";
            this.uxFetchSituationOfAssetButton.UseVisualStyleBackColor = true;
            // 
            // uxGetPossibleAssetsButton
            // 
            this.uxGetPossibleAssetsButton.Location = new System.Drawing.Point(1805, 1323);
            this.uxGetPossibleAssetsButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxGetPossibleAssetsButton.Name = "uxGetPossibleAssetsButton";
            this.uxGetPossibleAssetsButton.Size = new System.Drawing.Size(432, 139);
            this.uxGetPossibleAssetsButton.TabIndex = 48;
            this.uxGetPossibleAssetsButton.Text = "Get Possible Assets";
            this.uxGetPossibleAssetsButton.UseVisualStyleBackColor = true;
            // 
            // uxAssetAssetNameLabel
            // 
            this.uxAssetAssetNameLabel.AutoSize = true;
            this.uxAssetAssetNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAssetAssetNameLabel.Location = new System.Drawing.Point(1476, 1225);
            this.uxAssetAssetNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxAssetAssetNameLabel.Name = "uxAssetAssetNameLabel";
            this.uxAssetAssetNameLabel.Size = new System.Drawing.Size(243, 54);
            this.uxAssetAssetNameLabel.TabIndex = 47;
            this.uxAssetAssetNameLabel.Text = "Asset Name:";
            // 
            // uxAssetAssetNameTextBox
            // 
            this.uxAssetAssetNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAssetAssetNameTextBox.Location = new System.Drawing.Point(1741, 1225);
            this.uxAssetAssetNameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAssetAssetNameTextBox.Name = "uxAssetAssetNameTextBox";
            this.uxAssetAssetNameTextBox.Size = new System.Drawing.Size(733, 61);
            this.uxAssetAssetNameTextBox.TabIndex = 46;
            // 
            // uxFetchCheckoutHistoryButton
            // 
            this.uxFetchCheckoutHistoryButton.Location = new System.Drawing.Point(1805, 185);
            this.uxFetchCheckoutHistoryButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxFetchCheckoutHistoryButton.Name = "uxFetchCheckoutHistoryButton";
            this.uxFetchCheckoutHistoryButton.Size = new System.Drawing.Size(432, 139);
            this.uxFetchCheckoutHistoryButton.TabIndex = 51;
            this.uxFetchCheckoutHistoryButton.Text = "Fetch Checkout History";
            this.uxFetchCheckoutHistoryButton.UseVisualStyleBackColor = true;
            this.uxFetchCheckoutHistoryButton.Click += new System.EventHandler(this.uxFetchCheckoutHistoryButton_Click);
            // 
            // uxAssetUserIDLabel
            // 
            this.uxAssetUserIDLabel.AutoSize = true;
            this.uxAssetUserIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAssetUserIDLabel.Location = new System.Drawing.Point(1515, 77);
            this.uxAssetUserIDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxAssetUserIDLabel.Name = "uxAssetUserIDLabel";
            this.uxAssetUserIDLabel.Size = new System.Drawing.Size(150, 54);
            this.uxAssetUserIDLabel.TabIndex = 50;
            this.uxAssetUserIDLabel.Text = "UserID:";
            // 
            // uxAssetUserIDTextBox
            // 
            this.uxAssetUserIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAssetUserIDTextBox.Location = new System.Drawing.Point(1741, 77);
            this.uxAssetUserIDTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxAssetUserIDTextBox.Name = "uxAssetUserIDTextBox";
            this.uxAssetUserIDTextBox.Size = new System.Drawing.Size(733, 61);
            this.uxAssetUserIDTextBox.TabIndex = 49;
            // 
            // uxFetchCheckoutHistoryGridView
            // 
            this.uxFetchCheckoutHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxFetchCheckoutHistoryGridView.Location = new System.Drawing.Point(1375, 359);
            this.uxFetchCheckoutHistoryGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxFetchCheckoutHistoryGridView.Name = "uxFetchCheckoutHistoryGridView";
            this.uxFetchCheckoutHistoryGridView.RowHeadersWidth = 62;
            this.uxFetchCheckoutHistoryGridView.RowTemplate.Height = 33;
            this.uxFetchCheckoutHistoryGridView.Size = new System.Drawing.Size(1277, 728);
            this.uxFetchCheckoutHistoryGridView.TabIndex = 52;
            // 
            // uxFetchSituationOfAssetGridView
            // 
            this.uxFetchSituationOfAssetGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxFetchSituationOfAssetGridView.Location = new System.Drawing.Point(20, 1504);
            this.uxFetchSituationOfAssetGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxFetchSituationOfAssetGridView.Name = "uxFetchSituationOfAssetGridView";
            this.uxFetchSituationOfAssetGridView.RowHeadersWidth = 62;
            this.uxFetchSituationOfAssetGridView.RowTemplate.Height = 33;
            this.uxFetchSituationOfAssetGridView.Size = new System.Drawing.Size(1277, 728);
            this.uxFetchSituationOfAssetGridView.TabIndex = 77;
            // 
            // uxGetPossibleAssetsGridView
            // 
            this.uxGetPossibleAssetsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGetPossibleAssetsGridView.Location = new System.Drawing.Point(1375, 1504);
            this.uxGetPossibleAssetsGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxGetPossibleAssetsGridView.Name = "uxGetPossibleAssetsGridView";
            this.uxGetPossibleAssetsGridView.RowHeadersWidth = 62;
            this.uxGetPossibleAssetsGridView.RowTemplate.Height = 33;
            this.uxGetPossibleAssetsGridView.Size = new System.Drawing.Size(1277, 728);
            this.uxGetPossibleAssetsGridView.TabIndex = 78;
            // 
            // Asset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2703, 2108);
            this.Controls.Add(this.uxGetPossibleAssetsGridView);
            this.Controls.Add(this.uxFetchSituationOfAssetGridView);
            this.Controls.Add(this.uxFetchCheckoutHistoryGridView);
            this.Controls.Add(this.uxFetchCheckoutHistoryButton);
            this.Controls.Add(this.uxAssetUserIDLabel);
            this.Controls.Add(this.uxAssetUserIDTextBox);
            this.Controls.Add(this.uxGetPossibleAssetsButton);
            this.Controls.Add(this.uxAssetAssetNameLabel);
            this.Controls.Add(this.uxAssetAssetNameTextBox);
            this.Controls.Add(this.uxFetchSituationOfAssetButton);
            this.Controls.Add(this.uxAssetAssetIDLabel);
            this.Controls.Add(this.uxAssetAssetIDTextBox);
            this.Controls.Add(this.uxLine5);
            this.Controls.Add(this.uxLine4);
            this.Controls.Add(this.uxAddChildren);
            this.Controls.Add(this.uxAddAdventure);
            this.Controls.Add(this.uxAddAction);
            this.Controls.Add(this.uxAddRPG);
            this.Controls.Add(this.uxAddSimulation);
            this.Controls.Add(this.uxAddSport);
            this.Controls.Add(this.uxAddMMO);
            this.Controls.Add(this.uxAddHumor);
            this.Controls.Add(this.uxAddTravel);
            this.Controls.Add(this.uxAddHistory);
            this.Controls.Add(this.uxAddHealth);
            this.Controls.Add(this.uxAddCooking);
            this.Controls.Add(this.uxAddMemoir);
            this.Controls.Add(this.uxAddHorror);
            this.Controls.Add(this.uxAddMystery);
            this.Controls.Add(this.uxAddRomance);
            this.Controls.Add(this.uxAddFantasy);
            this.Controls.Add(this.uxAddCompanyTextBox);
            this.Controls.Add(this.uxAddLNameTextBox);
            this.Controls.Add(this.uxAddFNameTextBox);
            this.Controls.Add(this.uxAddCompanyLabel);
            this.Controls.Add(this.uxAddLNameLabel);
            this.Controls.Add(this.uxAddFNameLabel);
            this.Controls.Add(this.uxAddDate);
            this.Controls.Add(this.uxAddTypeDDL);
            this.Controls.Add(this.uxAddCategoriesLabel);
            this.Controls.Add(this.uxAddCreatorLabel);
            this.Controls.Add(this.uxTypeLabel);
            this.Controls.Add(this.uxAddRelDateLabel);
            this.Controls.Add(this.uxAddAssetButton);
            this.Controls.Add(this.uxAddNameLabel);
            this.Controls.Add(this.uxAddNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Asset";
            this.Text = "Asset";
            ((System.ComponentModel.ISupportInitialize)(this.uxFetchCheckoutHistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxFetchSituationOfAssetGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGetPossibleAssetsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxTypeLabel;
        private System.Windows.Forms.Label uxAddRelDateLabel;
        private System.Windows.Forms.Button uxAddAssetButton;
        private System.Windows.Forms.Label uxAddNameLabel;
        private System.Windows.Forms.TextBox uxAddNameTextBox;
        private System.Windows.Forms.Label uxAddCreatorLabel;
        private System.Windows.Forms.Label uxAddCategoriesLabel;
        private System.Windows.Forms.ComboBox uxAddTypeDDL;
        private System.Windows.Forms.DateTimePicker uxAddDate;
        private System.Windows.Forms.Label uxAddFNameLabel;
        private System.Windows.Forms.Label uxAddLNameLabel;
        private System.Windows.Forms.Label uxAddCompanyLabel;
        private System.Windows.Forms.TextBox uxAddFNameTextBox;
        private System.Windows.Forms.TextBox uxAddLNameTextBox;
        private System.Windows.Forms.TextBox uxAddCompanyTextBox;
        private System.Windows.Forms.CheckBox uxAddFantasy;
        private System.Windows.Forms.CheckBox uxAddRomance;
        private System.Windows.Forms.CheckBox uxAddMystery;
        private System.Windows.Forms.CheckBox uxAddHorror;
        private System.Windows.Forms.CheckBox uxAddMemoir;
        private System.Windows.Forms.CheckBox uxAddCooking;
        private System.Windows.Forms.CheckBox uxAddHealth;
        private System.Windows.Forms.CheckBox uxAddHistory;
        private System.Windows.Forms.CheckBox uxAddTravel;
        private System.Windows.Forms.CheckBox uxAddHumor;
        private System.Windows.Forms.CheckBox uxAddMMO;
        private System.Windows.Forms.CheckBox uxAddSport;
        private System.Windows.Forms.CheckBox uxAddSimulation;
        private System.Windows.Forms.CheckBox uxAddRPG;
        private System.Windows.Forms.CheckBox uxAddAction;
        private System.Windows.Forms.CheckBox uxAddAdventure;
        private System.Windows.Forms.CheckBox uxAddChildren;
        private System.Windows.Forms.Label uxLine4;
        private System.Windows.Forms.Label uxLine5;
        private System.Windows.Forms.Label uxAssetAssetIDLabel;
        private System.Windows.Forms.TextBox uxAssetAssetIDTextBox;
        private System.Windows.Forms.Button uxFetchSituationOfAssetButton;
        private System.Windows.Forms.Button uxGetPossibleAssetsButton;
        private System.Windows.Forms.Label uxAssetAssetNameLabel;
        private System.Windows.Forms.TextBox uxAssetAssetNameTextBox;
        private System.Windows.Forms.Button uxFetchCheckoutHistoryButton;
        private System.Windows.Forms.Label uxAssetUserIDLabel;
        private System.Windows.Forms.TextBox uxAssetUserIDTextBox;
        private System.Windows.Forms.DataGridView uxFetchCheckoutHistoryGridView;
        private System.Windows.Forms.DataGridView uxFetchSituationOfAssetGridView;
        private System.Windows.Forms.DataGridView uxGetPossibleAssetsGridView;
    }
}