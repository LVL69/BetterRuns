using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;


namespace BetterRuns
{




    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            path = Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            path = Path.Combine(path, "Documents\\20XX");
            listbox.DoubleClick += new EventHandler(listbox_DoubleClick);
        }

        Dictionary<int, string> augdict = new Dictionary<int, string>
        {
            { 200, "Plumber Hat" },
            { 201, "Strongarm Band" },
            { 202, "Ninja Sash" },
            { 204, "Power Enhancer" },
            { 206, "Heart Container" },
            { 207, "Blue Lander" },
            { 208, "Potato Battery" },
            { 209, "Brain Food Lunch" },
            { 210, "Zephyr" },
            { 213, "Forcemetal Shell" },
            { 214, "XCALBER" },
            { 215, "Glass Cannon" },
            { 218, "Vitality Scavenger" },
            { 219, "Energy Scavenger" },
            { 220, "Scrapmetal Scavenger" },
            { 221, "Seven Leaf Clover" },
            { 222, "Spillover Matrix" },
            { 223, "Health Nut" },
            { 224, "Charged Nuts" },
            { 228, "Nut Replicator" },
            { 229, "Minimech O. Grinder" },
            { 230, "Murderdrone" },
            { 231, "Skittery Smuggler" },
            { 232, "Shinier Token" },
            { 233, "Nutstack" },
            { 234, "Re-Flapp" },
            { 235, "Tiny Flamespewer" },
            { 236, "Gapminder" },
            { 237, "The Rebeginner" },
            { 238, "Shockwave Sidekick" },
            { 239, "Vendsmasher" },
            { 240, "Nutsaving Stringwire" },
            { 241, "Armor Nut" },
            { 242, "Regenerative Plating" },
            { 243, "Enerative Plating" },
            { 244, "Armorative Plating" },
            { 246, "Thrift Actuator" },
            { 247, "Crisis Overdrive" },
            { 248, "Crisis Timestopper" },
            { 249, "System Restore" },
            { 250, "Armor Spreader" },
            { 251, "Choicebooster" },
            { 252, "Armor Bloom" },
            { 253, "Meganut" },
            { 254, "Pure Flame" },
            { 255, "Forgotten Memento" },
            { 256, "Bracer of Battle" },
            { 257, "Hypersash" },
            { 258, "Life Extender" },
            { 259, "Megaheart" },
            { 260, "Vibroreserve" },
            { 261, "Reclaimed Spark" },
            { 262, "Armor Scavenger" },
            { 263, "Entropy Lock" },
            { 264, "Striking Feather" },
            { 265, "Thunderous Boon" },
            { 266, "Band of Might" },
            { 267, "Mistimed Protector" },
            { 268, "The Volunteer" },
            { 269, "Thrillseeker" },
            { 270, "Quantum Spook" },
            { 271, "Hoarder's Might" },
            { 272, "Contractor Plus" },
            { 273, "Contractor Omega" },
            { 274, "Mixmatch Mastery" },
            { 275, "Charging Magnet" },
            { 276, "World Slug" },
            { 277, "Leafmetal Plating" },
            { 278, "Zookeeper's Sigil" },
            { 280, "Static Clicklets" },
            { 281, "Fortune Stabilizer" },
            { 282, "Spicy Incense" },
            { 283, "Patchwork Connector" },
            { 284, "Vitaboost" },
            { 285, "Thorned Hull" },
            { 286, "Juiced Reserves" },
            { 287, "Kinetic Converter" },
            { 288, "Dashbolt" },
            { 290, "Utilifier" },
            { 291, "Vibrofocus" },
            { 292, "Leafpetal" },
            { 293, "Splintering Twinifier" },
            { 294, "Zookeeper's Zeal" },
            { 295, "Crisis Lifebank" },
            { 296, "Deconstructor's Might" },
            { 297, "Armorall" },
            { 298, "Unflappable" },
            { 299, "Intensifier" },
            { 300, "Force Resonator" },
            { 301, "Case Resonator" },
            { 302, "Cranial Resonator" },
            { 303, "Kinetic Resonator" },
            { 328, "Sanity Converter" },
            { 329, "Violence Enhancer" },
            { 330, "Defiant Decree" },
            { 331, "Brutish Augmentation" },
            { 332, "Focusing Sagelens" },
            { 333, "Earthmetal Plating" },
            { 334, "Interesting Times" },
            { 335, "Uncharging Force" },
            { 336, "Final Shell" },
            { 337, "Zookeeper's Burden" },
            { 338, "Consuming Fury" },
            { 339, "Hysteria" },
            { 340, "Contractor Beta" },
            { 341, "Kingseeker" },
            { 342, "Vitality Partitioner" },
            { 343, "Patchwork Integrator" },
            { 344, "Enlightenment" },
            { 380, "Armatort Chest" },
            { 384, "Armatort Head" },
            { 388, "Armatort Leg" },
            { 392, "Armatort Arm" },
            { 381, "Oxjack Chest" },
            { 385, "Oxjack Head" },
            { 389, "Oxjack Leg" },
            { 393, "Oxjack Arm" },
            { 382, "Dracopent Chest" },
            { 386, "Dracopent Head" },
            { 390, "Dracopent Leg" },
            { 394, "Dracopent Arm" },
            { 383, "Owlhawk Chest" },
            { 387, "Owlhawk Head" },
            { 391, "Owlhawk Leg" },
            { 395, "Owlhawk Arm" },
            //{ 203, "Sprint Shoes" },
            //{ 205, "Gold Stud" },
            //{ 211, "White Feather" },
            //{ 212, "Blood Magic" },
            //{ 216, "Aerial Stabilizer" },
            //{ 217, "No Leaf Clover" },
            //{ 225, "Energy Armor" },
            //{ 226, "Nut Farm" },
            //{ 227, "Nutrageous" },
            //{ 245, "Emergency Beacon" },
            //{ 289, "Reflex Rapidifier" }
        };

        Dictionary<int, string> contractordict = new Dictionary<int, string>
        {
            { 0, "Nina" },
            { 1, "Ace" },
            { 2, "Vika" },
            { 3, "Jest" },
            { 4, "Draco" },
            { 5, "Hawk" }
        };

        Dictionary<int, string> weapondict = new Dictionary<int, string>
        {
            { 0, "" },
            { 17, "N-Buster" },
            { 18, "Star Beam" },
            { 19, "Forkalator" },
            { 20, "Wave Beam" },
            { 21, "Scatterblast" },
            { 49, "V-Shooter" },
            { 25, "A-Saber" },
            { 26, "Rippling Axe" },
            { 27, "Plasma Blender" },
            { 28, "Glaive" },
            { 29, "Sharp Sharp Spear" },
            { 30, "J-Cutter" },
            { 31, "The Siphon (Whip)" },
            { 33, "Unstoppable Force (Hammer)" },
            { 34, "Twinblade (Boomerang)" },
            { 35, "Vega" },
            { 36, "Peacebringer" },
            { 37, "Gemini" },
            { 38, "Rapture" }
            

        };

        Dictionary<int, string> powerdict = new Dictionary<int, string>
        {
            { 0, "" },
            { 100, "Vera" },
            { 101, "Mortar" },
            { 102, "Boomerang Blade" },
            { 103, "Dixie Twist" },
            { 104, "Shadespur" },
            { 106, "Quint Laser" },
            { 107, "Transposer" },
            { 108, "Flameshield" },
            { 109, "Splinterfrost" },
            { 110, "Force Nova" },
            { 111, "Wildfire" },
            { 112, "Blastjump" },
            { 113, "Seeking Striker" },
            { 114, "Protorifle" },
            { 119, "World Igniter" },
            { 158, "Al Laser (crashes in menu)" }

        };

        Dictionary<int, string> modedict = new Dictionary<int, string>
        {
            { 4, "Reverent" },
            { 0, "Normal" },
            { 3, "Defiant" },
            { 5, "Daily Challenge" },
            { 6, "Daily Hardcore Challenge" },
            { 7, "Weekly Challenge" },
            { 8, "Weekly Hardcore Challenge" },
            { 9, "Rush Job" },
            { 10, "Seed Racer" }

        };

        Dictionary<int, string> bossdict = new Dictionary<int, string>
        {                       
            { 1, "Rollster" },
            { 2, "Perforator" },
            { 3, "Death Lotus" },
            { 4, "Twin Astrals" },
            { 5, "Shatterbeak" },
            { 6, "Vile Visage" },
            { 7, "Kur" },
            { 8, "Eternal Star" },            
            { 10, "Brighton Sharp" },
            { 11, "Arlan Flat" },
            { 0, "Bugnisort" },
            { 9, "Brighton's Buggy Brother" }            

        };

        byte[] thefile = new byte[] { };
        List<byte> origfile = new List<byte>();
        List<byte> modfile = new List<byte>();
        List<int> auglist = new List<int>();
        List<int> offsets = new List<int>();
        List<int> bosslist = new List<int>();
        string path = null;
        Stream myStream = null;
        int contractoroffset;
        int currentlevel = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        


        private void btn_openfile_Click(object sender, EventArgs e)
        {

            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "20XX RUN files|*.run";






            theDialog.InitialDirectory = path;
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            //enable save button
                            btn_save.Enabled = true;


                            thefile = ReadStream(myStream);
                            origfile = thefile.ToList();

                            contractoroffset = GetContractorOffset(origfile);
                            offsets = GetAugBlockOffsets(contractoroffset, 91, origfile);



                            auglist = GetAugValues(origfile, offsets);
                            modfile = DeleteAugs(origfile, offsets);
                            
                            
                            bosslist = GetBossValues(modfile, GetBossBlockOffsets(contractoroffset - 3, origfile));


                            //write buttons into aug flowlayoutpanel
                            panel.Controls.Clear();

                            for (int i = 0; i < auglist.Count; i++)
                            { 
                                Button mybutton = new Button();
                                mybutton.AutoSize = true;
                                mybutton.Text = augdict[auglist[i]];
                                mybutton.Tag = auglist[i];
                                mybutton.Click += new EventHandler(DynamicButton_Click);
                                panel.Controls.Add(mybutton);
                            }


                            num_nuts.Enabled = true;
                            num_HP.Enabled = true;
                            num_NRG.Enabled = true;
                            num_tokens.Enabled = true;
                            num_armor.Enabled = true;
                            num_level.Enabled = true;
                            listbox.Enabled = true;
                            listbox.Items.Clear();
                            AddAugsToListbox();
                            auglistlabel.Enabled = true;
                            buttonlistlabel.Enabled = true;
                            label_character.Enabled = true;
                            label_nuts.Enabled = true;
                            label_mode.Enabled = true;
                            label_HP.Enabled = true;
                            label_NRG.Enabled = true;
                            label_armor.Enabled = true;
                            label_tokens.Enabled = true;
                            label_seed.Enabled = true;
                            label_level.Enabled = true;
                            panel_stats.Enabled = true;
                            textbox_seed.Enabled = true;
                            panel_portals.Enabled = true;

                            if (combobox_mode.SelectedIndex == 0)
                            {
                                label_lives.Enabled = true;
                                num_lives.Enabled = true;
                            }
                            panel_weaponspowers.Enabled = true;

                            //get current level
                            currentlevel = bosslist.Count;
                            num_level.Value = currentlevel;


                            //get nuts
                            num_nuts.Value = GetNutValue(4, modfile);

                            //get tokens
                            num_tokens.Value = GetNutValue(8, modfile);

                            //get HP + NRG + armor + stats
                            num_HP.Value = GetHPValue(contractoroffset, 71, modfile) / 1000;
                            num_NRG.Value = Decimal.Divide(GetHPValue(contractoroffset, 79, modfile), 1000);
                            num_armor.Value = GetHPValue(contractoroffset, 87, modfile) / 1000;
                            num_maxHP.Value = GetHPValue(contractoroffset, 5, modfile) / 1000;
                            num_maxNRG.Value = GetHPValue(contractoroffset, 13, modfile) / 1000;
                            num_atk.Value = GetHPValue(contractoroffset, 21, modfile);
                            num_pwr.Value = GetHPValue(contractoroffset, 29, modfile);
                            num_spd.Value = GetHPValue(contractoroffset, 37, modfile);
                            num_jmp.Value = GetHPValue(contractoroffset, 45, modfile);                       

                            //get contractor
                            combobox_contractors.Enabled = true;
                            combobox_contractors.Items.Clear();
                            FillContractorCombobox();
                            combobox_contractors.SelectedIndex = GetContractorValue(contractoroffset, modfile);

                            //get portals
                            combobox_portal1.Items.Clear();
                            combobox_portal2.Items.Clear();
                            combobox_portal3.Items.Clear();
                            FillPortals(combobox_portal1);
                            FillPortals(combobox_portal2);
                            FillPortals(combobox_portal3);
                            combobox_portal1.SelectedItem = bossdict[GetPortalValue(30, modfile)];
                            combobox_portal2.SelectedItem = bossdict[GetPortalValue(32, modfile)];
                            combobox_portal3.SelectedItem = bossdict[GetPortalValue(34, modfile)];

                            //get mode value
                            combobox_mode.Enabled = true;
                            combobox_mode.Items.Clear();
                            FillModeCombobox();
                            combobox_mode.SelectedItem = modedict[GetModeValue(modfile)];

                            //get lives
                            num_lives.Value = GetLivesValue(modfile);

                            //get seed
                            textbox_seed.Text = DecimalToArbitrarySystem(GetSeedValue(12, modfile), 36);

                            //get main weapon
                            combobox_mainweapon.Enabled = true;
                            combobox_mainweapon.Items.Clear();
                            FillMainWeaponCombobox(combobox_mainweapon);
                            combobox_mainweapon.SelectedItem = weapondict[GetMainWeaponValue(contractoroffset, modfile, 0)];

                            //get power 1
                            combobox_power1.Enabled = true;
                            combobox_power1.Items.Clear();
                            FillPowerCombobox(combobox_power1);
                            combobox_power1.SelectedItem = powerdict[GetMainWeaponValue(contractoroffset, modfile, 2)];

                            //get powers 2-8
                            FDracoPowers(combobox_power2, 4, false);
                            FDracoPowers(combobox_power3, 6, false);
                            FDracoPowers(combobox_power4, 8, false);
                            FDracoPowers(combobox_power5, 10, false);
                            FDracoPowers(combobox_power6, 12, false);
                            FDracoPowers(combobox_power7, 14, false);
                            FDracoPowers(combobox_power8, 16, false);                                         
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
           
            List<byte> tempmodfile = new List<byte>(modfile);
            List<int> tempbosslist = new List<int>(bosslist);


            //write nuts
            WriteNutValue(num_nuts, 4, tempmodfile);

            //write tokens
            WriteNutValue(num_tokens, 8, tempmodfile);

            //write HP + NRG + armor + stats
            WriteHPValue(num_HP, contractoroffset, 71, tempmodfile);
            WriteHPValue(num_NRG, contractoroffset, 79, tempmodfile);
            WriteHPValue(num_armor, contractoroffset, 87, tempmodfile);
            WriteHPValue(num_maxHP, contractoroffset, 5, tempmodfile);
            WriteHPValue(num_maxNRG, contractoroffset, 13, tempmodfile);
            WriteStatValue(num_atk, contractoroffset, 21, tempmodfile);
            WriteStatValue(num_pwr, contractoroffset, 29, tempmodfile);
            WriteStatValue(num_spd, contractoroffset, 37, tempmodfile);
            WriteStatValue(num_jmp, contractoroffset, 45, tempmodfile);

            //write contractor
            WriteContractorValue(tempmodfile);

            //write portals
            WritePortalValue(combobox_portal1, 30, tempmodfile);
            WritePortalValue(combobox_portal2, 32, tempmodfile);
            WritePortalValue(combobox_portal3, 34, tempmodfile);

            //write mode
            WriteModeValue(tempmodfile);

            //write lives
            if (combobox_mode.SelectedIndex == 0)
            {
                WriteLivesValue(tempmodfile);
            }

            //write seed
            try
            {
                WriteSeedValue(textbox_seed, 12, tempmodfile);
            }
            catch
            {

            }

            //write main weapon
            WriteMainWeaponValue(combobox_mainweapon, tempmodfile, 0);

            //write power 1
            WritePowerValue(combobox_power1, tempmodfile, 2);

            //write powers 2-8
            if (combobox_contractors.SelectedIndex == 4)
            {
                WriteMainWeaponValue(combobox_power2, tempmodfile, 4);
                WriteMainWeaponValue(combobox_power3, tempmodfile, 6);
                WriteMainWeaponValue(combobox_power4, tempmodfile, 8);
                WriteMainWeaponValue(combobox_power5, tempmodfile, 10);
                WriteMainWeaponValue(combobox_power6, tempmodfile, 12);
                WriteMainWeaponValue(combobox_power7, tempmodfile, 14);
                WriteMainWeaponValue(combobox_power8, tempmodfile, 16);
            }
            else
            {
                WritePowerValue(combobox_power2, tempmodfile, 4);
                WritePowerValue(combobox_power3, tempmodfile, 6);
                WritePowerValue(combobox_power4, tempmodfile, 8);
                WritePowerValue(combobox_power5, tempmodfile, 10);
                WritePowerValue(combobox_power6, tempmodfile, 12);
                WritePowerValue(combobox_power7, tempmodfile, 14);
                WritePowerValue(combobox_power8, tempmodfile, 16);
            }


            //write augs
            byte[] augbits = new byte[2];
            for (int i = panel.Controls.Count-1; i >= 0; i--)
            {
                int btntag = Convert.ToInt32(panel.Controls[i].Tag);
                augbits = BitConverter.GetBytes(btntag);
                tempmodfile.Insert(offsets[0], augbits[0]);
                tempmodfile.Insert(offsets[0], augbits[1]);
            }

            //write level/boss sequence
            DeleteBosses(tempmodfile, GetBossBlockOffsets(contractoroffset - 3, modfile), currentlevel);

            
            if (Convert.ToInt32(num_level.Value) > currentlevel)
            {
                IncreaseLevel(tempbosslist, BossListDefeatedInCycle(tempbosslist, currentlevel), BossesDefeatedInCycle(currentlevel), Convert.ToInt32(num_level.Value) - currentlevel);
                
            }

            if (Convert.ToInt32(num_level.Value) < currentlevel)
            {
                DecreaseLevel(tempbosslist, currentlevel - Convert.ToInt32(num_level.Value));

            }

            WriteBosses(tempmodfile, GetBossBlockOffsets(contractoroffset - 3, modfile), tempbosslist);






            //create final file
            byte[] finalfile = new byte[] { };
            finalfile = tempmodfile.ToArray();

            SaveFileDialog theSaveDialog = new SaveFileDialog();
            theSaveDialog.Title = "Save .run file";
            theSaveDialog.Filter = "run files|*.run";
            theSaveDialog.FileName = "20xx.run";
            theSaveDialog.CheckFileExists = false;
            theSaveDialog.CheckPathExists = true;
            if (theSaveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(theSaveDialog.FileName, finalfile);
            }

            //offsets = GetAugBlockOffsets(tempmodfile);
            //contractoroffset = GetContractorOffset(tempmodfile);
            //origfile = new List<byte>(tempmodfile);
            //offsets = GetAugBlockOffsets(modfile);

        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            panel.Controls.Remove(btn);
        }


        public static byte[] ReadStream(Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }

        

        ////Old way of finding offsets
        //public List<int> GetAugBlockOffsets(List<byte> input)
        //{
        //    List<int> b = new List<int>();
        //    for (var i = input.Count - 73; i > 0; i -= 2)
        //    {
        //        byte[] temp = { input[i], input[i - 1] };
        //        int result = BitConverter.ToUInt16(temp, 0);
        //        if(!augdict.ContainsKey(result))
        //        {
        //            b.Add(i+1);
        //            b.Add(input.Count - 74);
        //            break;
        //        }                         
        //    }
            

        //    return b;
        //}


        public List<int> GetAugBlockOffsets(int coffset, int exoffset, List<byte> input)
        {
            List<int> b = new List<int>();
            b.Add(coffset + exoffset);
            b.Add(input.Count - 74);                                               
            return b;
        }

        public List<int> GetBossBlockOffsets(int offset, List<byte> input)
        {
            List<int> c = new List<int>();
            for (var i = offset; i > 0; i--)
            {
                byte[] temp = { input[i], 0x0 };
                int result = BitConverter.ToUInt16(temp, 0);
                if (result < 1 || result > 10)
                {
                    c.Add(i + 1);
                    c.Add(offset);
                    break;
                }
            }
            return c;
        }




        public void FillContractorCombobox()
        {
            combobox_contractors.Items.Add(contractordict[0]);
            combobox_contractors.Items.Add(contractordict[1]);
            combobox_contractors.Items.Add(contractordict[2]);
            combobox_contractors.Items.Add(contractordict[3]);
            combobox_contractors.Items.Add(contractordict[4]);
            combobox_contractors.Items.Add(contractordict[5]);
        }

        public void FillPortals(ComboBox comb)
        {

            for (int i = 0; i < bossdict.Count; i++)
            {
                comb.Items.Add(bossdict.Values.ElementAt(i));
            }
        }

        public void FillMainWeaponCombobox(ComboBox cbox)
        {
            for (int i = 0; i < weapondict.Count; i++)
            {
                cbox.Items.Add(weapondict.Values.ElementAt(i));
            }
            
        }

        public void FillPowerCombobox(ComboBox cbox)
        {
            for (int i = 0; i < powerdict.Count; i++)
            {
                cbox.Items.Add(powerdict.Values.ElementAt(i));
            }

        }

        public void FillModeCombobox()
        {
            for (int i = 0; i < modedict.Count; i++)
            {
                combobox_mode.Items.Add(modedict.Values.ElementAt(i));
            }

        }

        public void AddAugsToListbox()
        {

            

            foreach (KeyValuePair<int, string> entry in augdict)
            {
                listbox.Items.Add(entry.Value);
            }
        }

        //Get current augs
        public List<int> GetAugValues(List<byte> file, List<int> offsets)
        {
            List<int> a = new List<int>();
            for (int i = offsets[0]; i <= offsets[1]; i += 2)
            {
                byte[] temp = { file[i+1], file[i] };
                int result = BitConverter.ToInt16(temp, 0);
                a.Add(result);
            }
            return a;
        }


        //Get defeated bosses
        public List<int> GetBossValues(List<byte> file, List<int> offsets)
        {
            List<int> d = new List<int>();
            for (int i = offsets[0]; i <= offsets[1]; i++)
            {
                byte[] temp = { file[i], 0x0 };
                int result = BitConverter.ToInt16(temp, 0);
                d.Add(result);
            }
            return d;
        }

        //for Endless: Check how many bosses were defeated in current 8-level cycle
        public int BossesDefeatedInCycle(int currentlevel)
        {
            int y = currentlevel % 8;
            return y;
        }

        public List<int> BossListDefeatedInCycle(List<int> bosslist, int currentlevel)
        {
            List<int> k = new List<int>();

                int y = currentlevel % 8;
                for (int i = bosslist.Count - 1 ; i >= bosslist.Count - y; i--)
                {
                    k.Add(bosslist[i]);
                }

            return k;
        }


        public void IncreaseLevel(List<int> bosslist, List<int> defeatedbosslist, int defeatedbosses, int howmanylevels)
        {

            List<int> m = RandomBossList();
            int j = 0;
            int remainingbosses = 8 - defeatedbosses;
            while (defeatedbosses > 0 && howmanylevels > 0)
            {
                m.Remove(defeatedbosslist[j]);
                j++;
                defeatedbosses--;
                
                //remainingbosses--;
            }


            //howmanylevels = howmanylevels - remainingbosses;


            for (int i = 0; i < m.Count; i++)
            {
                if (howmanylevels == 0)
                {
                    break;
                }

                bosslist.Add(m[i]);
                howmanylevels--;
            }

            while (howmanylevels > 7)
            {
                List<int> n = RandomBossList();
                for (int i = 0; i < n.Count; i++)
                {
                    bosslist.Add(n[i]);
                }
                howmanylevels = howmanylevels - 8;
            }

            List<int> o = RandomBossList();
            for (int i = 0; i < 8 - howmanylevels; i++)
            {
                o.RemoveAt(0);
            }

            for (int i = 0; i < o.Count; i++)
            {
                bosslist.Add(o[i]);
            }

        }


        public void DecreaseLevel(List<int> bosslist, int howmanylevels)
        {
            for (int i = 0; i < howmanylevels; i++)
            {
                bosslist.RemoveAt(bosslist.Count - 1);
            }
        }

        public List<int> RandomBossList()
        {
            List<int> r = new List<int>(new int[] {1,2,3,4,5,6,7,8});
            r = r.OrderBy(a => Guid.NewGuid()).ToList();
            return r;
        }


        public int GetNutValue(int offset, List<byte> file)
        {
            byte[] temp = { file[offset + 3], file[offset + 2], file[offset + 1], file[offset] };
            int result = BitConverter.ToInt32(temp, 0);
            
            return result;
        }

        public void WriteNutValue(NumericUpDown nud, int offset, List<byte> file)
        {     
            byte[] augbits = new byte[4];
            int btntag = Convert.ToInt32(nud.Value);
            augbits = BitConverter.GetBytes(btntag);
            file[offset] = augbits[3];
            file[offset + 1] = augbits[2];
            file[offset + 2] = augbits[1];
            file[offset + 3] = augbits[0];
        }

        public int GetHPValue(int offset, int exoffset, List<byte> file)
        {

            int tempoffset = offset + exoffset;
            byte[] temp = { file[tempoffset+3], file[tempoffset + 2], file[tempoffset + 1], file[tempoffset] };
            int result = BitConverter.ToInt32(temp, 0);

            return result;
        }

        public void WriteHPValue(NumericUpDown nud, int offset, int exoffset, List<byte> file)
        {
            int tempoffset = offset + exoffset;
            byte[] augbits = new byte[4];
            double btntag2 = Convert.ToDouble(nud.Value);
            btntag2 = btntag2 * 1000;
            int btntag = Convert.ToInt32(btntag2);
            augbits = BitConverter.GetBytes(btntag);
            file[tempoffset] = augbits[3];
            file[tempoffset + 1] = augbits[2];
            file[tempoffset + 2] = augbits[1];
            file[tempoffset + 3] = augbits[0];
        }

        public void WriteStatValue(NumericUpDown nud, int offset, int exoffset, List<byte> file)
        {
            int tempoffset = offset + exoffset;
            byte[] augbits = new byte[4];            
            int btntag = Convert.ToInt32(nud.Value);
            augbits = BitConverter.GetBytes(btntag);
            file[tempoffset] = augbits[3];
            file[tempoffset + 1] = augbits[2];
            file[tempoffset + 2] = augbits[1];
            file[tempoffset + 3] = augbits[0];
        }

        public long GetSeedValue(int offset, List<byte> file)
        {            
            byte[] temp = { file[offset + 7], file[offset + 6], file[offset + 5], file[offset + 4], file[offset + 3], file[offset + 2], file[offset + 1], file[offset] };
            long result = BitConverter.ToInt64(temp, 0);

            return result;
        }

        public void WriteSeedValue(TextBox text, int offset, List<byte> file)
        {
            byte[] augbits = new byte[8];
            long btntag = ArbitraryToDecimalSystem(text.Text, 36);
            augbits = BitConverter.GetBytes(btntag);
            file[offset] = augbits[7];
            file[offset + 1] = augbits[6];
            file[offset + 2] = augbits[5];
            file[offset + 3] = augbits[4];
            file[offset + 4] = augbits[3];
            file[offset + 5] = augbits[2];
            file[offset + 6] = augbits[1];
            file[offset + 7] = augbits[0];
        }


        public int GetContractorValue(int offset, List<byte> file)
        {
            if (offset != 0)
            {
                byte[] temp = new byte[] {file[offset], 0x0 };
                int result = BitConverter.ToInt16(temp,0);
                return result;
            }
            else
            {
                return 0;
            }
        }

        public int GetPortalValue(int offset, List<byte> file)
        {
                byte[] temp = new byte[] { file[offset], 0x0 };
                int result = BitConverter.ToInt16(temp, 0);
                return result;            
        }

        public int GetContractorOffset(List<byte> file)
        {
            for (int i = 50; i < file.Count - 1; i++)
            {
                if (file[i] == 35)
                {
                    if (file[i+1] == 1)
                    {
                        return i + 2;
                        
                    }
                }
            }
            
            return 0;
        }

        public void WriteContractorValue(List<byte> file)
        {
            byte[] augbits = new byte[1];
            int btntag = Convert.ToInt16(combobox_contractors.SelectedIndex);
            augbits = BitConverter.GetBytes(btntag);
            file[GetContractorOffset(file)] = augbits[0];
        }

        public void WritePortalValue(ComboBox comb, int offset, List<byte> file)
        {
            byte[] augbits = new byte[1];
            int btntag = Convert.ToInt16(bossdict.Keys.ElementAt(comb.SelectedIndex));
            augbits = BitConverter.GetBytes(btntag);
            file[offset] = augbits[0];
        }

        public int GetMainWeaponValue(int offset, List<byte> file, int exoffset)
        {
            if (offset != 0)
            {
                byte[] temp = new byte[] { file[offset + 50 + exoffset], file[offset + 49 + exoffset] };
                int result = BitConverter.ToInt16(temp, 0);
                return result;
            }
            else
            {
                return 0;
            }
        }

        public void WriteMainWeaponValue(ComboBox cbox, List<byte> file, int exoffset)
        {
            byte[] augbits = new byte[2];
            int btntag = Convert.ToInt16(weapondict.Keys.ElementAt(cbox.SelectedIndex));
            augbits = BitConverter.GetBytes(btntag);
            file[GetContractorOffset(file) + 49 + exoffset] = augbits[1];
            file[GetContractorOffset(file) + 50 + exoffset] = augbits[0];
        }

        public void WritePowerValue(ComboBox cbox, List<byte> file, int exoffset)
        {
            byte[] augbits = new byte[2];
            int btntag = Convert.ToInt16(powerdict.Keys.ElementAt(cbox.SelectedIndex));
            augbits = BitConverter.GetBytes(btntag);
            file[GetContractorOffset(file) + 49 + exoffset] = augbits[1];
            file[GetContractorOffset(file) + 50 + exoffset] = augbits[0];
        }


        public int GetModeValue(List<byte> file)
        {

            byte[] temp = { file[file.Count-1], 0x0 };
            int result = BitConverter.ToInt16(temp, 0);
            return result;
        }

        public void WriteModeValue(List<byte> file)
        {
            byte[] augbits = new byte[2];
            int btntag = Convert.ToInt16(modedict.Keys.ElementAt(combobox_mode.SelectedIndex));
            augbits = BitConverter.GetBytes(btntag);
            file[file.Count-1] = augbits[0];
        }





        //Feed power comboboxes with main weapons if Draco
        public void FDracoPowers(ComboBox cbox, int exoffset, bool changechar)
        {
            cbox.Enabled = true;
            cbox.Items.Clear();
            if (combobox_contractors.SelectedIndex == 4)
            {
                FillMainWeaponCombobox(cbox);
                if (changechar == false)
                {
                    cbox.SelectedItem = weapondict[GetMainWeaponValue(GetContractorOffset(modfile), modfile, exoffset)];
                }
            }
            else
            {
                FillPowerCombobox(cbox);
                if (changechar == false)
                {
                    cbox.SelectedItem = powerdict[GetMainWeaponValue(GetContractorOffset(modfile), modfile, exoffset)];
                }
                
            }
        }

        public int GetLivesValue(List<byte> file)
        {

            byte[] temp = { file[file.Count-2], 0x0 };
            int result = BitConverter.ToInt16(temp, 0);
            return result;
        }

        public void WriteLivesValue(List<byte> file)
        {
            byte[] augbits = new byte[2];
            int btntag = Convert.ToInt16(num_lives.Value);
            augbits = BitConverter.GetBytes(btntag);
            file[file.Count-2] = augbits[0];         
        }




        public void ToDraco()
        {
            label_power1.Text = "Power";
            label_power2.Text = "Main Weapon 2";
            label_power3.Text = "Main Weapon 3";
            label_power4.Text = "Main Weapon 4";
            label_power5.Text = "Main Weapon 5";
            label_power6.Text = "Main Weapon 6";
            label_power7.Text = "Main Weapon 7";
            label_power8.Text = "Main Weapon 8";
        }

        public void ToNotDraco()
        {
            label_power1.Text = "Power 1";
            label_power2.Text = "Power 2";
            label_power3.Text = "Power 3";
            label_power4.Text = "Power 4";
            label_power5.Text = "Power 5";
            label_power6.Text = "Power 6";
            label_power7.Text = "Power 7";
            label_power8.Text = "Power 8";
        }

        public List<byte> DeleteAugs(List<byte> file, List<int> offsets)
        {
            List<byte> a = new List<byte>(file);
            a.RemoveRange(offsets[0], offsets[1] - offsets[0] + 2);
            return a;
        }

        public void DeleteBosses(List<byte> file, List<int> offsetlist, int howmanylevels)
        {
            for (int i = 0; i < howmanylevels; i++)
            {
                file.RemoveAt(offsetlist[0]);
            }                                   
        }

        public void WriteBosses(List<byte> file, List<int> offsetlist, List<int> bosslist)
        {
            byte[] augbits = new byte[1];
            for (int i = bosslist.Count -1 ; i >= 0; i--)
            {
                
                augbits = BitConverter.GetBytes(bosslist[i]);
                file.Insert(offsetlist[0], augbits[0]);
                
            }
        }



        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listbox_DoubleClick(object sender, EventArgs e)
        {
            if (listbox.SelectedItem != null)
            {
                
                int key = augdict.Keys.ElementAt(listbox.SelectedIndex);

                Button mybutton = new Button();
                mybutton.AutoSize = true;
                mybutton.Text = augdict[key];
                mybutton.Tag = key;
                mybutton.Click += new EventHandler(DynamicButton_Click);
                panel.Controls.Add(mybutton);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_contractors.SelectedIndex == 4)
            {
                ToDraco();
            }
            else
            {
                ToNotDraco();
            }
            try
            {
                FDracoPowers(combobox_power2, 4, false);
            }
            catch (Exception er)
            {
                FDracoPowers(combobox_power2, 4, true);
                combobox_power2.SelectedIndex = 0;
            }

            try
            {
                FDracoPowers(combobox_power3, 6, false);
            }
            catch (Exception er)
            {
                FDracoPowers(combobox_power3, 6, true);
                combobox_power3.SelectedIndex = 0;
            }

            try
            {
                FDracoPowers(combobox_power4, 8, false);
            }
            catch (Exception er)
            {
                FDracoPowers(combobox_power4, 8, true);
                combobox_power4.SelectedIndex = 0;
            }

            try
            {
                FDracoPowers(combobox_power5, 10, false);
            }
            catch (Exception er)
            {
                FDracoPowers(combobox_power5, 10, true);
                combobox_power5.SelectedIndex = 0;
            }

            try
            {
                FDracoPowers(combobox_power6, 12, false);
            }
            catch (Exception er)
            {
                FDracoPowers(combobox_power6, 12, true);
                combobox_power6.SelectedIndex = 0;
            }

            try
            {
                FDracoPowers(combobox_power7, 14, false);
            }
            catch (Exception er)
            {
                FDracoPowers(combobox_power7, 14, true);
                combobox_power7.SelectedIndex = 0;
            }

            try
            {
                FDracoPowers(combobox_power8, 16, false);
            }
            catch (Exception er)
            {
                FDracoPowers(combobox_power8, 16, true);
                combobox_power8.SelectedIndex = 0;
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void combobox_mainweapon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void combobox_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_mode.SelectedIndex == 0)
            {
                label_lives.Enabled = true;
                num_lives.Enabled = true;
            }
            else
            {
                label_lives.Enabled = false;
                num_lives.Enabled = false;
            }
        }

      





        //base converter functions by Pavel Vladov
        public static string DecimalToArbitrarySystem(long decimalNumber, int radix)
        {
            const int BitsInLong = 64;
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " + Digits.Length.ToString());

            if (decimalNumber == 0)
                return "0";

            int index = BitsInLong - 1;
            long currentNumber = Math.Abs(decimalNumber);
            char[] charArray = new char[BitsInLong];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % radix);
                charArray[index--] = Digits[remainder];
                currentNumber = currentNumber / radix;
            }

            string result = new String(charArray, index + 1, BitsInLong - index - 1);
            if (decimalNumber < 0)
            {
                result = "-" + result;
            }

            return result;
        }

        public static long ArbitraryToDecimalSystem(string number, int radix)
        {
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " +
                    Digits.Length.ToString());

            if (String.IsNullOrEmpty(number))
                return 0;

            // Make sure the arbitrary numeral system number is in upper case
            number = number.ToUpperInvariant();

            long result = 0;
            long multiplier = 1;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                char c = number[i];
                if (i == 0 && c == '-')
                {
                    // This is the negative sign symbol
                    result = -result;
                    break;
                }

                int digit = Digits.IndexOf(c);
                if (digit == -1)
                    throw new ArgumentException(
                        "Invalid character in the arbitrary numeral system number",
                        "number");

                result += digit * multiplier;
                multiplier *= radix;
            }

            return result;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }
    }








    //Class for using an external .txt file to override default dictionaries. Not yet implemented.
    public class RList
    {
        Dictionary<byte, string> itemvalues = new Dictionary<byte, string>();

        static Regex augspar = new Regex("^---Augs");
        static Regex stop = new Regex("^---");
        static Regex itval = new Regex("^[0-9a-fA-F][0-9a-fA-F] ?[0-9a-fA-F][0-9a-fA-F] - .");
        public int horst = 2;
        public static string[] defaultaugs = {"00 C8 - Plumber Hat",
                                        "00 C9 - Strongarm Band",
                                        "00 CA - Ninja Sash",
                                        "00 CC - Power Enhancer",
                                        "00 CE - Heart Container",
                                        "00 CF - Blue Lander",
                                        "00 D0 - Potato Battery",
                                        "00 D1 - Brain Food Lunch",
                                        "00 D2 - Zephyr",
                                        "00 D5 - Forcemetal Shell",
                                        "00 D6 - XCALBER",
                                        "00 D7 - Glass Cannon",
                                        "00 DA - Vitality Scavenger",
                                        "00 DB - Energy Scavenger",
                                        "00 DC - Scrapmetal Scavenger",
                                        "00 DD - Seven Leaf Clover",
                                        "00 DE - Spillover Matrix",
                                        "00 DF - Health Nut",
                                        "00 E0 - Charged Nuts",
                                        "00 E4 - Nut Replicator",
                                        "00 E5 - Minimech O. Grinder",
                                        "00 E6 - Murderdrone",
                                        "00 E7 - Skittery Smuggler",
                                        "00 E8 - Shinier Token",
                                        "00 E9 - Nutstack",
                                        "00 EA - Re-Flapp",
                                        "00 EB - Tiny Flamespewer",
                                        "00 EC - Gapminder",
                                        "00 ED - The Rebeginner",
                                        "00 EE - Shockwave Sidekick",
                                        "00 EF - Vendsmasher",
                                        "00 F0 - Nutsaving Stringwire",
                                        "00 F1 - Armor Nut",
                                        "00 F2 - Regenerative Plating",
                                        "00 F3 - Enerative Plating",
                                        "00 F4 - Armorative Plating",
                                        "00 F6 - Thrift Actuator",
                                        "00 F7 - Crisis Overdrive",
                                        "00 F8 - Crisis Timestopper",
                                        "00 F9 - System Restore",
                                        "00 FA - Armor Spreader",
                                        "00 FB - Choicebooster",
                                        "00 FC - Armor Bloom",
                                        "00 FD - Meganut",
                                        "00 FE - Pure Flame",
                                        "00 FF - Forgotten Memento",
                                        "01 00 - Bracer of Battle",
                                        "01 01 - Hypersash",
                                        "01 02 - Life Extender",
                                        "01 03 - Megaheart",
                                        "01 04 - Vibroreserve",
                                        "01 05 - Reclaimed Spark",
                                        "01 06 - Armor Scavenger",
                                        "01 07 - Entropy Lock",
                                        "01 08 - Striking Feather",
                                        "01 09 - Thunderous Boon",
                                        "01 0A - Band of Might",
                                        "01 0B - Mistimed Protector",
                                        "01 0C - The Volunteer",
                                        "01 0D - Thrillseeker",
                                        "01 0E - Quantum Spook",
                                        "01 0F - Hoarder's Might",
                                        "01 10 - Contractor Plus",
                                        "01 11 - Contractor Omega",
                                        "01 12 - Mixmatch Mastery",
                                        "01 13 - Charging Magnet",
                                        "01 14 - World Slug",
                                        "01 15 - Leafmetal Plating",
                                        "01 16 - Zookeeper's Sigil",
                                        "01 18 - Static Clicklets",
                                        "01 19 - Fortune Stabilizer",
                                        "01 1A - Spicy Incense",
                                        "01 1B - Patchwork Connector",
                                        "01 1C - Vitaboost",
                                        "01 1D - Thorned Hull",
                                        "01 1E - Juiced Reserves",
                                        "01 1F - Kinetic Converter",
                                        "01 20 - Dashbolt",
                                        "01 22 - Utilifier",
                                        "01 23 - Vibrofocus",
                                        "01 24 - Leafpetal",
                                        "01 25 - Splintering Twinifier",
                                        "01 26 - Zookeeper's Zeal",
                                        "01 27 - Crisis Lifebank",
                                        "01 28 - Deconstructor's Might",
                                        "01 29 - Armorall",
                                        "01 2A - Unflappable",
                                        "01 2B - Intensifier",
                                        "01 2C - Force Resonator",
                                        "01 2D - Case Resonator",
                                        "01 2E - Cranial Resonator",
                                        "01 2F - Kinetic Resonator",
                                        "01 48 - Sanity Converter",
                                        "01 49 - Violence Enhancer",
                                        "01 4A - Defiant Decree",
                                        "01 4B - Brutish Augmentation",
                                        "01 4C - Focusing Sagelens",
                                        "01 4D - Earthmetal Plating",
                                        "01 4E - Interesting Times",
                                        "01 4F - Uncharging Force",
                                        "01 50 - Final Shell",
                                        "01 51 - Zookeeper's Burden",
                                        "01 52 - Consuming Fury",
                                        "01 53 - Hysteria",
                                        "01 54 - Contractor Beta",
                                        "01 55 - Kingseeker",
                                        "01 56 - Vitality Partitioner",
                                        "01 57 - Patchwork Integrator",
                                        "01 58 - Enlightenment",
                                        "01 7C - Armatort Chest",
                                        "01 80 - Armatort Head",
                                        "01 84 - Armatort Leg",
                                        "01 88 - Armatort Arm",
                                        "01 7D - Oxjack Chest",
                                        "01 81 - Oxjack Head",
                                        "01 85 - Oxjack Leg",
                                        "01 89 - Oxjack Arm",
                                        "01 7E - Dracopent Chest",
                                        "01 82 - Dracopent Head",
                                        "01 86 - Dracopent Leg",
                                        "01 8A - Dracopent Arm",
                                        "01 7F - Owlhawk Chest",
                                        "01 83 - Owlhawk Head",
                                        "01 87 - Owlhawk Leg",
                                        "01 8B - Owlhawk Arm"};

        private byte testbyte;
        public byte Testbyte
        {
            get
            {
                return testbyte;
            }
            set
            {
                testbyte = value;
            }

        }

        //open file as string array
        public string[] opentxtfile(string filepath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filepath);
                return lines;
            }

            catch (Exception e)
            {
                Console.WriteLine("The file could not be read. Dunno what you did, but maybe this will help:");
                Console.WriteLine(e.Message);
                return new string[] { "" };
            }
        }

        public byte[] openrunfile(string filepath)
        {
            try
            {
                byte[] bytes = File.ReadAllBytes(filepath);
                return bytes;
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read. Dunno what you did, but maybe this will help:");
                Console.WriteLine(e.Message);
                return new byte[] { 00 };
            }
        }

        //get values from text file
        public string[] GetVals(string[] fileinfo)
        {
            List<string> result = new List<string>();

                string[] lines = fileinfo;
                for (int i = 0; i < lines.Length; i++)
                {
                    if (augspar.IsMatch(lines[i])) //if the line matches "--Augs"
                    {
                        for (int j = i + 1; j < lines.Length - i+1; j++) //iterate through remaining lines
                        {
                            if (stop.IsMatch(lines[j])) //if line matches "---"
                            {
                                break; //end of this loop
                            }
                            else
                            {
                                if (itval.IsMatch(lines[j])) //if it matches an item value
                                {
                                    result.Add(lines[j]); //add it to the return string list
                                }
                            }
                        }
                        break;
                    }
                }
                return result.ToArray();
        }

        public static Dictionary<int, string> ToDict(string[] stringarray)
        {
            Dictionary<int, string> resultdict = new Dictionary<int, string>();
            Regex bytetest = new Regex("^[0-9a-fA-F][0-9a-fA-F] [0-9a-fA-F][0-9a-fA-F]");
            foreach (string item in stringarray)
            {
                string temp = item;
                if(bytetest.IsMatch(item))
                {
                    temp = item.Substring(0, 2) + item.Substring(3);
                }
                resultdict.Add(Int32.Parse(temp.Substring(0, 4), System.Globalization.NumberStyles.HexNumber), temp.Substring(7));
                
            }



            return resultdict;
        }



    }
}
