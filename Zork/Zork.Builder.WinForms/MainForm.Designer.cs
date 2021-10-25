
namespace Zork_Builder
{
    partial class MainForm
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.World = new System.Windows.Forms.TabPage();
            this.RoomName = new System.Windows.Forms.Label();
            this.EditRoomButton = new System.Windows.Forms.Button();
            this.RemoveRoomButton = new System.Windows.Forms.Button();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.NeighborBox = new System.Windows.Forms.GroupBox();
            this.SouthNeighborButton = new System.Windows.Forms.Button();
            this.EastNeighborButton = new System.Windows.Forms.Button();
            this.WestNeighborButton = new System.Windows.Forms.Button();
            this.NorthNeighborButton = new System.Windows.Forms.Button();
            this.RoomsList = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.StartingLocation = new System.Windows.Forms.Label();
            this.Items = new System.Windows.Forms.TabPage();
            this.Game = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.Files = new System.Windows.Forms.TabPage();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RoomDescription = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.World.SuspendLayout();
            this.NeighborBox.SuspendLayout();
            this.Game.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem3,
            this.menuItem5,
            this.menuItem6});
            this.menuItem1.Text = "File";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Save Game File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Options";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.World);
            this.tabControl.Controls.Add(this.Items);
            this.tabControl.Controls.Add(this.Game);
            this.tabControl.Controls.Add(this.Files);
            this.tabControl.Location = new System.Drawing.Point(1, -2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(659, 418);
            this.tabControl.TabIndex = 0;
            // 
            // World
            // 
            this.World.Controls.Add(this.textBox3);
            this.World.Controls.Add(this.RoomDescription);
            this.World.Controls.Add(this.textBox2);
            this.World.Controls.Add(this.RoomName);
            this.World.Controls.Add(this.EditRoomButton);
            this.World.Controls.Add(this.RemoveRoomButton);
            this.World.Controls.Add(this.AddRoomButton);
            this.World.Controls.Add(this.NeighborBox);
            this.World.Controls.Add(this.RoomsList);
            this.World.Controls.Add(this.listBox1);
            this.World.Controls.Add(this.comboBox1);
            this.World.Controls.Add(this.StartingLocation);
            this.World.Location = new System.Drawing.Point(4, 22);
            this.World.Name = "World";
            this.World.Padding = new System.Windows.Forms.Padding(3);
            this.World.Size = new System.Drawing.Size(651, 392);
            this.World.TabIndex = 0;
            this.World.Text = "World";
            this.World.UseVisualStyleBackColor = true;
            // 
            // RoomName
            // 
            this.RoomName.AutoSize = true;
            this.RoomName.Location = new System.Drawing.Point(240, 3);
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(66, 13);
            this.RoomName.TabIndex = 8;
            this.RoomName.Text = "Room Name";
            // 
            // EditRoomButton
            // 
            this.EditRoomButton.Location = new System.Drawing.Point(11, 321);
            this.EditRoomButton.Name = "EditRoomButton";
            this.EditRoomButton.Size = new System.Drawing.Size(75, 23);
            this.EditRoomButton.TabIndex = 7;
            this.EditRoomButton.Text = "Edit";
            this.EditRoomButton.UseVisualStyleBackColor = true;
            // 
            // RemoveRoomButton
            // 
            this.RemoveRoomButton.Location = new System.Drawing.Point(11, 350);
            this.RemoveRoomButton.Name = "RemoveRoomButton";
            this.RemoveRoomButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveRoomButton.TabIndex = 6;
            this.RemoveRoomButton.Text = "Remove";
            this.RemoveRoomButton.UseVisualStyleBackColor = true;
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(11, 291);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(75, 23);
            this.AddRoomButton.TabIndex = 5;
            this.AddRoomButton.Text = "Add";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            // 
            // NeighborBox
            // 
            this.NeighborBox.Controls.Add(this.SouthNeighborButton);
            this.NeighborBox.Controls.Add(this.EastNeighborButton);
            this.NeighborBox.Controls.Add(this.WestNeighborButton);
            this.NeighborBox.Controls.Add(this.NorthNeighborButton);
            this.NeighborBox.Location = new System.Drawing.Point(243, 85);
            this.NeighborBox.Name = "NeighborBox";
            this.NeighborBox.Size = new System.Drawing.Size(400, 300);
            this.NeighborBox.TabIndex = 4;
            this.NeighborBox.TabStop = false;
            this.NeighborBox.Text = "Neighbors";
            // 
            // SouthNeighborButton
            // 
            this.SouthNeighborButton.Location = new System.Drawing.Point(165, 239);
            this.SouthNeighborButton.Name = "SouthNeighborButton";
            this.SouthNeighborButton.Size = new System.Drawing.Size(75, 23);
            this.SouthNeighborButton.TabIndex = 3;
            this.SouthNeighborButton.Text = "South";
            this.SouthNeighborButton.UseVisualStyleBackColor = true;
            // 
            // EastNeighborButton
            // 
            this.EastNeighborButton.Location = new System.Drawing.Point(278, 145);
            this.EastNeighborButton.Name = "EastNeighborButton";
            this.EastNeighborButton.Size = new System.Drawing.Size(75, 23);
            this.EastNeighborButton.TabIndex = 2;
            this.EastNeighborButton.Text = "East";
            this.EastNeighborButton.UseVisualStyleBackColor = true;
            // 
            // WestNeighborButton
            // 
            this.WestNeighborButton.Location = new System.Drawing.Point(45, 145);
            this.WestNeighborButton.Name = "WestNeighborButton";
            this.WestNeighborButton.Size = new System.Drawing.Size(75, 23);
            this.WestNeighborButton.TabIndex = 1;
            this.WestNeighborButton.Text = "West";
            this.WestNeighborButton.UseVisualStyleBackColor = true;
            // 
            // NorthNeighborButton
            // 
            this.NorthNeighborButton.Location = new System.Drawing.Point(165, 54);
            this.NorthNeighborButton.Name = "NorthNeighborButton";
            this.NorthNeighborButton.Size = new System.Drawing.Size(75, 23);
            this.NorthNeighborButton.TabIndex = 0;
            this.NorthNeighborButton.Text = "North";
            this.NorthNeighborButton.UseVisualStyleBackColor = true;
            // 
            // RoomsList
            // 
            this.RoomsList.AutoSize = true;
            this.RoomsList.Location = new System.Drawing.Point(8, 43);
            this.RoomsList.Name = "RoomsList";
            this.RoomsList.Size = new System.Drawing.Size(40, 13);
            this.RoomsList.TabIndex = 3;
            this.RoomsList.Text = "Rooms";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 225);
            this.listBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // StartingLocation
            // 
            this.StartingLocation.AutoSize = true;
            this.StartingLocation.Location = new System.Drawing.Point(8, 3);
            this.StartingLocation.Name = "StartingLocation";
            this.StartingLocation.Size = new System.Drawing.Size(87, 13);
            this.StartingLocation.TabIndex = 0;
            this.StartingLocation.Text = "Starting Location";
            // 
            // Items
            // 
            this.Items.Location = new System.Drawing.Point(4, 22);
            this.Items.Name = "Items";
            this.Items.Padding = new System.Windows.Forms.Padding(3);
            this.Items.Size = new System.Drawing.Size(651, 392);
            this.Items.TabIndex = 1;
            this.Items.Text = "Items";
            this.Items.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            this.Game.Controls.Add(this.textBox1);
            this.Game.Controls.Add(this.WelcomeMessage);
            this.Game.Location = new System.Drawing.Point(4, 22);
            this.Game.Name = "Game";
            this.Game.Padding = new System.Windows.Forms.Padding(3);
            this.Game.Size = new System.Drawing.Size(651, 392);
            this.Game.TabIndex = 2;
            this.Game.Text = "Game";
            this.Game.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Welcome to Zork!";
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Location = new System.Drawing.Point(7, 3);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(98, 13);
            this.WelcomeMessage.TabIndex = 0;
            this.WelcomeMessage.Text = "Welcome Message";
            // 
            // Files
            // 
            this.Files.Location = new System.Drawing.Point(4, 22);
            this.Files.Name = "Files";
            this.Files.Padding = new System.Windows.Forms.Padding(3);
            this.Files.Size = new System.Drawing.Size(651, 392);
            this.Files.TabIndex = 3;
            this.Files.Text = "Files";
            this.Files.UseVisualStyleBackColor = true;
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "New Game File";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "Open Game File";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 3;
            this.menuItem6.Text = "-";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 20);
            this.textBox2.TabIndex = 9;
            // 
            // RoomDescription
            // 
            this.RoomDescription.AutoSize = true;
            this.RoomDescription.Location = new System.Drawing.Point(243, 42);
            this.RoomDescription.Name = "RoomDescription";
            this.RoomDescription.Size = new System.Drawing.Size(91, 13);
            this.RoomDescription.TabIndex = 10;
            this.RoomDescription.Text = "Room Description";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(243, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(340, 20);
            this.textBox3.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 419);
            this.Controls.Add(this.tabControl);
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            this.tabControl.ResumeLayout(false);
            this.World.ResumeLayout(false);
            this.World.PerformLayout();
            this.NeighborBox.ResumeLayout(false);
            this.Game.ResumeLayout(false);
            this.Game.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage World;
        private System.Windows.Forms.Label RoomsList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label StartingLocation;
        private System.Windows.Forms.TabPage Items;
        private System.Windows.Forms.TabPage Game;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.TabPage Files;
        private System.Windows.Forms.GroupBox NeighborBox;
        private System.Windows.Forms.Button SouthNeighborButton;
        private System.Windows.Forms.Button EastNeighborButton;
        private System.Windows.Forms.Button WestNeighborButton;
        private System.Windows.Forms.Button NorthNeighborButton;
        private System.Windows.Forms.Button RemoveRoomButton;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.Button EditRoomButton;
        private System.Windows.Forms.Label RoomName;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label RoomDescription;
        private System.Windows.Forms.TextBox textBox2;
    }
}

