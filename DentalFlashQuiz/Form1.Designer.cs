using System.Windows.Forms;

namespace DentalFlashQuiz
{
    partial class Form1
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

        private void createLabel(
            System.Windows.Forms.Label label,
            int pX,
            int pY,
            int sX,
            int sY,
            int tabIndex,
            string name,
            string tag,
            string text
            ) {
            label = new System.Windows.Forms.Label();
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(pX, pY);
            label.Name = name;
            label.Size = new System.Drawing.Size(sX, sY);
            label.TabIndex = tabIndex;
            label.Tag = tag;
            label.Text = text;
            label.Click += new System.EventHandler(this.Object_Click);
            this.Controls.Add(label);
        }

        private void createPictureBox(
            System.Windows.Forms.PictureBox picBox,
            System.Drawing.Bitmap bitmap,
            int pX,
            int pY,
            int sX,
            int sY,
            int tabIndex,
            string name,
            string tag
            ) {
            picBox.Image = bitmap;
            picBox.Location = new System.Drawing.Point(pX, pY);
            picBox.Name = name;
            picBox.Size = new System.Drawing.Size(sX, sY);
            picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picBox.TabIndex = tabIndex;
            picBox.TabStop = false;
            picBox.Tag = tag;
            picBox.Click += new System.EventHandler(this.Object_Click);
            this.Controls.Add(picBox);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExplorerP = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
            this.SuspendLayout();

            createLabel(ExplorerL, 21, 266, 216, 25, 1, "ExplorerL", "Air Water Syringe Tip", "Air/Water Syringe Tip");
            createPictureBox(ExplorerP, global::DentalFlashQuiz.Properties.Resources.AirWaterSyringeTip, 51, 30, 143, 233, 0, "ExplorerP", "Air Water Syringe Tip");
            createLabel(label1, 256, 266, 172, 35, 3, "label1", "Amalgam Carrier", "Amalgam Carrier");
            createPictureBox(pictureBox1, global::DentalFlashQuiz.Properties.Resources.AmalgamCarrier, 269, 30, 143, 233, 2, "pictureBox1", "Amalgam Carrier");
            createLabel(label2, 449, 266, 228, 25, 5, "label2", "Anesthetic Syring Tip", "Anesthetic Syring Tip");
            createPictureBox(pictureBox2, global::DentalFlashQuiz.Properties.Resources.AnestheticSyringeTip, 451, 30, 209, 233, 4, "pictureBox2", "Anesthetic Syringe Tip");
            createLabel(label3, 697, 266, 218, 25, 7, "label3", "Anterior Sickle Scaler", "Anterior Sickle Scaler");
            createPictureBox(pictureBox3, global::DentalFlashQuiz.Properties.Resources.AnteriorSickleScaler, 699, 30, 209, 233, 6, "pictureBox3", "Anterior Sickle Scaler");
            createLabel(label4, 108, 544, 43, 25, 12, "label4", "Bib", "Bib");
            createPictureBox(pictureBox4, global::DentalFlashQuiz.Properties.Resources.BallBurnisher, 934, 30, 209, 233, 8, "pictureBox4", "Ball Burnisher");
            createLabel(label5, 967, 266, 146, 25, 10, "label5", "Ball Burnisher", "Ball Burnisher");
            createPictureBox(pictureBox5, global::DentalFlashQuiz.Properties.Resources.Bib, 26, 308, 209, 233, 11, "pictureBox5", "Bib");
            createLabel(label6, 300, 544, 112, 25, 14, "label6", "Bite Paper", "Bite Paper");
            createPictureBox(pictureBox6, global::DentalFlashQuiz.Properties.Resources.BitePaper, 252, 308, 209, 233, 13, "pictureBox6", "Bite Paper");
            createLabel(label7, 496, 544, 181, 25, 16, "label7", "Bite Paper Holder", "Bite Paper Holder");
            createPictureBox(pictureBox7, global::DentalFlashQuiz.Properties.Resources.BitePaperHolder, 477, 308, 209, 233, 15, "pictureBox7", "Bite Paper Holder");
            createLabel(label8, 754, 544, 104, 25, 18, "label8", "Bur Block", "Bur Block");
            createPictureBox(pictureBox8, global::DentalFlashQuiz.Properties.Resources.BurBlock, 699, 308, 209, 233, 19, "pictureBox8", "Bur Block");
            createLabel(label9, 948, 544, 183, 25, 20, "label9", "Bur Medium Size", "Bur(Medium Size)");
            createPictureBox(pictureBox9, global::DentalFlashQuiz.Properties.Resources.BurMediumSize, 934, 308, 209, 233, 19, "pictureBox9", "Bur Medium Size");
            createLabel(label10, 87, 808, 76, 25, 22, "label10", "Carver", "Carver");
            createPictureBox(pictureBox10, global::DentalFlashQuiz.Properties.Resources.Carver, 26, 572, 209, 233, 21, "pictureBox10", "Carver");
            createLabel(label11, 300, 808, 128, 25, 24, "label11", "Cavitron Tip", "Cavitron Tip");
            createPictureBox(pictureBox11, global::DentalFlashQuiz.Properties.Resources.CavitronTip, 252, 572, 209, 233, 23, "picturesBox11", "Cavitron Tip");
            createLabel(label12, 536, 808, 93, 25, 26, "label12", "Chamfer", "Chamfer");
            createPictureBox(pictureBox12, global::DentalFlashQuiz.Properties.Resources.Chamfer, 477, 572, 209, 233, 25, "pictureBox12", "Chamfer");
            createLabel(label13, 761, 808, 117, 25, 28, "label13", "Condenser", "Condenser");
            createPictureBox(pictureBox13, global::DentalFlashQuiz.Properties.Resources.Condenser, 702, 572, 209, 233, 27, "pictureBox13", "Condenser");
            createLabel(label14, 982, 808, 131, 25, 30, "label14", "Cord Packer", "Cord Packer");
            createPictureBox(pictureBox14, global::DentalFlashQuiz.Properties.Resources.CordPacker, 934, 572, 209, 233, 29, "pictureBox14", "Cord Packer");
            createLabel(label15, 74, 1072, 124, 25, 32, "label15", "Cotton Plier", "Cotton Plier");
            createPictureBox(pictureBox15, global::DentalFlashQuiz.Properties.Resources.CottonPlier, 26, 836, 209, 233, 31, "pictureBox15", "Cotton Plier");
            createLabel(label16, 300, 1072, 118, 25, 34, "label16", "Cotton Roll", "Cotton Roll");
            createPictureBox(pictureBox16, global::DentalFlashQuiz.Properties.Resources.CottonRoll, 252, 836, 209, 233, 33, "pictureBox16", "Cotton Roll");
            createLabel(label17, 516, 1072, 134, 25, 36, "label17", "Cotton Swab", "Cotton Swab");
            createPictureBox(pictureBox17, global::DentalFlashQuiz.Properties.Resources.CottonSwab, 477, 836, 209, 233, 35, "pictureBox17", "Cotton Swab");
            createLabel(label18, 697, 1072, 219, 25, 38, "label18", "Diamond Football Bur", "Diamond/Football Bur");
            createPictureBox(pictureBox18, global::DentalFlashQuiz.Properties.Resources.Diamond_FootballBur, 702, 836, 209, 233, 37, "pictureBox18", "Diamond Football Bur");
            createLabel(label19, 965, 1072, 148, 25, 40, "label19", "Endo Explorer", "Endo Explorer");
            createPictureBox(pictureBox19, global::DentalFlashQuiz.Properties.Resources.EndoExplorer, 934, 836, 209, 233, 39, "pictureBox19", "Endo Explorer");
            createLabel(label20, 85, 1336, 92, 25, 42, "label20", "Explorer", "Explorer");
            createPictureBox(pictureBox20, global::DentalFlashQuiz.Properties.Resources.Explorer, 26, 1100, 209, 233, 41, "pictureBox20", "Explorer");
            createLabel(label21, 328, 1336, 58, 25, 44, "label21", "Files", "Files");
            createPictureBox(pictureBox21, global::DentalFlashQuiz.Properties.Resources.Files, 252, 1100, 209, 233, 43, "pictureBox21", "Files");
            createLabel(label22, 525, 1336, 116, 25, 46, "label22", "Flat Ended", "Flat Ended");
            createPictureBox(pictureBox22, global::DentalFlashQuiz.Properties.Resources.FlatEnded, 477, 1100, 209, 233, 45, "pictureBox22", "Flat Ended");
            createLabel(label23, 775, 1336, 64, 25, 48, "label23", "Floss", "Floss");
            createPictureBox(pictureBox23, global::DentalFlashQuiz.Properties.Resources.Floss, 702, 1100, 209, 233, 47, "pictureBox23", "Floss");
            createLabel(label24, 1004, 1336, 75, 25, 50, "label24", "Gauze", "Gauze");
            createPictureBox(pictureBox24, global::DentalFlashQuiz.Properties.Resources.Gauze, 931, 1100, 209, 233, 49, "pictureBox24", "Gauze");
            createLabel(label25, 3, 1600, 250, 25, 52, "label25", "High Speed Hand Speed", "High-Speed Hand Speed");
            createPictureBox(pictureBox25, global::DentalFlashQuiz.Properties.Resources.HighSpeedHandSpeed, 26, 1364, 209, 233, 51, "pictureBox25", "High Speed Hand Speed");
            createLabel(label26, 247, 1600, 248, 25, 54, "label26", "High Volume Suction Tip", "High Volume Suction Tip");
            createPictureBox(pictureBox26, global::DentalFlashQuiz.Properties.Resources.HighVolumeSuctionTip, 252, 1364, 209, 233, 53, "pictureBox26", "High Volume Suction Tip");
            createLabel(label27, 488, 1600, 205, 25, 56, "label27", "Interproximal Carver", "Interproximal Carver");
            createPictureBox(pictureBox27, global::DentalFlashQuiz.Properties.Resources.InterproximalCarver, 477, 1364, 209, 233, 55, "pictureBox27", "Interproximal Carver");
            createLabel(label28, 713, 1600, 185, 25, 58, "label28", "Inverted Cone Bur", "Inverted Cone Bur");
            createPictureBox(pictureBox28, global::DentalFlashQuiz.Properties.Resources.InvertedConeBur, 702, 1364, 209, 233, 57, "pictureBox28", "Inverted Cone Bur");
            createLabel(label29, 986, 1600, 114, 25, 60, "label29", "Metal Dish", "Metal Dish");
            createPictureBox(pictureBox29, global::DentalFlashQuiz.Properties.Resources.MetalDish, 931, 1364, 209, 233, 59, "pictureBox29", "Metal Dish");
            createLabel(label30, 66, 1864, 126, 25, 62, "label30", "Micro brush", "Micro-brush");
            createPictureBox(pictureBox30, global::DentalFlashQuiz.Properties.Resources.MicroBrush, 26, 1628, 209, 233, 61, "pictureBox30", "Micro brush");
            createLabel(label31, 292, 1864, 134, 25, 64, "label31", "Mouth Mirror", "Mouth Mirror");
            createPictureBox(pictureBox31, global::DentalFlashQuiz.Properties.Resources.MouthMirror, 252, 1628, 209, 233, 63, "pictureBox31", "Mouth Mirro");
            createLabel(label32, 517, 1864, 125, 25, 66, "label32", "Perio Probe", "Perio Probe");
            createPictureBox(pictureBox32, global::DentalFlashQuiz.Properties.Resources.PerloProbe, 577, 1628, 209, 233, 65, "pictureBox32", "Perio Probe");
            createLabel(label33, 751, 1864, 111, 25, 68, "label33", "Pointy Bur", "Pointy Bur");
            createPictureBox(pictureBox33, global::DentalFlashQuiz.Properties.Resources.PointyBur, 702, 1628, 209, 233, 67, "pictureBox33", "Pointy Bur");
            createLabel(label34, 911, 1864, 229, 25, 70, "label34", "Posterior Sickle Scaler", "Posterior Sickle Scaler");
            createPictureBox(pictureBox34, global::DentalFlashQuiz.Properties.Resources.PosteriorSickleScaler, 931, 1628, 209, 233, 69, "pictureBox34", "Posterior Sickle Scaler");
            createLabel(label35, 66, 2128, 141, 25, 72, "label35", "Prophy Angle", "Prophy Angle");
            createPictureBox(pictureBox35, global::DentalFlashQuiz.Properties.Resources.ProphyAngle, 26, 1892, 209, 233, 71, "pictureBox35", "Prophy Angle");
            createLabel(label36, 292, 2128, 141, 25, 74, "label36", "Prophy Paste", "Prophy Paste");
            createPictureBox(pictureBox36, global::DentalFlashQuiz.Properties.Resources.ProphyPaste, 252, 1892, 209, 233, 73, "pictureBox36", "Prophy Paste");
            createLabel(label37, 545, 2128, 75, 25, 76, "label37", "Rotary", "Rotary");
            createPictureBox(pictureBox37, global::DentalFlashQuiz.Properties.Resources.Rotary, 477, 1892, 209, 233, 75, "pictureBox37", "Rotary");
            createLabel(label38, 748, 2128, 114, 25, 78, "label38", "Round Bur", "Round Bur");
            createPictureBox(pictureBox38, global::DentalFlashQuiz.Properties.Resources.RoundBur, 702, 1892, 209, 233, 77, "pictureBox38", "Round Bur");
            createLabel(label39, 970, 2128, 144, 25, 80, "label39", "Saliva Ejector", "Saliva Ejector");
            createPictureBox(pictureBox39, global::DentalFlashQuiz.Properties.Resources.SalivaEjector, 931, 1892, 209, 233, 79, "pictureBox39", "Saliva Ejector");
            createLabel(label40, -2, 2392, 252, 25, 82, "label40", "Slow Speed Hand Speed", "Slow Speed Hand Speed");
            createPictureBox(pictureBox40, global::DentalFlashQuiz.Properties.Resources.SlowSpeedHandSpeed, 26, 2156, 209, 233, 81, "pictureBox40", "Slow Speed Hand Speed");
            createLabel(label41, 309, 2392, 85, 25, 84, "label41", "Spatula", "Spatula");
            createPictureBox(pictureBox41, global::DentalFlashQuiz.Properties.Resources.Spatula, 252, 2156, 209, 233, 83, "pictureBox41", "Spatula");
            createLabel(label42, 546, 2392, 74, 25, 86, "label42", "Spoon", "Spoon");
            createPictureBox(pictureBox42, global::DentalFlashQuiz.Properties.Resources.Spoon, 477, 2156, 209, 233, 85, "pictureBox42", "Spoon");
            createLabel(label43, 725, 2392, 169, 25, 88, "label43", "Universal Scaler", "Universal Scaler");
            createPictureBox(pictureBox43, global::DentalFlashQuiz.Properties.Resources.UniversalScaler, 702, 2156, 209, 233, 87, "pictureBox43", "Universal Scaler");
            createLabel(label44, 970, 2392, 169, 25, 89, "label44", "Beautiful Flow Plus", "Beautiful Flow Plus");
            createPictureBox(pictureBox44, global::DentalFlashQuiz.Properties.Resources.BeautifulFlowPlus, 931, 2156, 209, 233, 90, "pictureBox44", "Beautiful Flow Plus");
            createLabel(label45, -10, 2656, 169, 25, 91, "label45", "Phosphoric Acid Etching Gel", "Phosphoric Acid Etching Gel");
            createPictureBox(pictureBox45, global::DentalFlashQuiz.Properties.Resources.PhosphoricAcidEtchingGel, 26, 2420, 209, 233, 92, "pictureBox45", "Phosphoric Acid Etching Gel");
            createLabel(label46, 250, 2656, 169, 25, 91, "label46", "Universal Bonding Agent", "Universal Bonding Agent");
            createPictureBox(pictureBox46, global::DentalFlashQuiz.Properties.Resources.UniversalBondingAgent, 252, 2420, 209, 233, 92, "pictureBox46", "Universal Bonding Agent");
            createLabel(label47, 490, 2656, 169, 25, 91, "label47", "Hemostatic Solution", "Hemostatic Solution");
            createPictureBox(pictureBox47, global::DentalFlashQuiz.Properties.Resources.HemostaticSolution, 477, 2420, 209, 233, 92, "pictureBox47", "Hemostatic Solution");
            createLabel(label48, 700, 2656, 169, 25, 91, "label48", "Topical Cream", "Topical Cream");
            createPictureBox(pictureBox48, global::DentalFlashQuiz.Properties.Resources.TopicalCream, 702, 2420, 209, 233, 92, "pictureBox48", "Topical Cream");
            createLabel(label49, 910, 2656, 169, 25, 91, "label49", "Gracey Curettes Double Ended", "Gracey Curettes Double Ended");
            createPictureBox(pictureBox49, global::DentalFlashQuiz.Properties.Resources.GraceyCurettesDoubleEnded, 931, 2420, 209, 233, 92, "pictureBox49", "Gracey Curettes Double Ended");
            createLabel(label50, 50, 2920, 169, 25, 91, "label50", "Carbide Burs", "Carbide Burs");
            createPictureBox(pictureBox50, global::DentalFlashQuiz.Properties.Resources.CarbideBurs, 26, 2684, 209, 233, 92, "pictureBox50", "Carbide Burs");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1186, 729);
            this.Controls.Add(this.pictureBox50);
            this.Controls.Add(this.pictureBox49);
            this.Controls.Add(this.pictureBox48);
            this.Controls.Add(this.pictureBox47);
            this.Controls.Add(this.pictureBox46);
            this.Controls.Add(this.pictureBox45);
            this.Controls.Add(this.pictureBox44);
            this.Controls.Add(this.pictureBox43);
            this.Controls.Add(this.pictureBox42);
            this.Controls.Add(this.pictureBox41);
            this.Controls.Add(this.pictureBox40);
            this.Controls.Add(this.pictureBox39);
            this.Controls.Add(this.pictureBox38);
            this.Controls.Add(this.pictureBox37);
            this.Controls.Add(this.pictureBox36);
            this.Controls.Add(this.pictureBox35);
            this.Controls.Add(this.pictureBox34);
            this.Controls.Add(this.pictureBox33);
            this.Controls.Add(this.pictureBox32);
            this.Controls.Add(this.pictureBox31);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.pictureBox29);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Dental Flash Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox ExplorerP;
        private System.Windows.Forms.Label ExplorerL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.PictureBox pictureBox28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.PictureBox pictureBox33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.PictureBox pictureBox34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.PictureBox pictureBox35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.PictureBox pictureBox36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.PictureBox pictureBox37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.PictureBox pictureBox38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.PictureBox pictureBox39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.PictureBox pictureBox40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.PictureBox pictureBox41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.PictureBox pictureBox42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.PictureBox pictureBox43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.PictureBox pictureBox44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.PictureBox pictureBox45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.PictureBox pictureBox46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.PictureBox pictureBox47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.PictureBox pictureBox48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.PictureBox pictureBox49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.PictureBox pictureBox50;
    }
}

