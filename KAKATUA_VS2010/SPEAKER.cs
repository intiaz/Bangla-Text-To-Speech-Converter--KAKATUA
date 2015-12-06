using IrrKlang;
using System.Threading;
using Detecting_Converting_String;
using System.Windows.Forms;
namespace KAKATUA
{
    public partial class BODY
    {
        int char_no = 0;
        public void SPEAK(object st)
        {

            int internal_preceding_vowel = 0, internal_character = 0;
            //var h=0x50;
            char ch = 'আ';
            int integer = 2437;
            ch = (char)integer;
            //MessageBox.Show(h.ToString());
            //float f=0;
            //////////////////////////////////////IrrKlang object start
            ISoundEngine engine = new ISoundEngine();
            ISound music = null;
            ISoundEffectControl fx = null;

            /////////////////////////////////IrrKlang object finished 
            Detect_Convert det_con_obj = new Detecting_Converting_String.Detect_Convert();
            string str = (string)st + "  END", play_string = " ";


            for (char_no = play_position.Value; char_no < str.Length - 5; char_no++)
            {

                play_position.Value = char_no;
                if (str[play_position.Value] == ' ')
                {
                    int i = play_position.Value + 1;
                    current_string = Editor.Text + "                ";
                    current_string = current_string.Substring(i, 15);
                    current_string = current_string.Substring(0, current_string.IndexOf(" "));
                    this.label1.Text = "বর্তমান শব্দ : " + current_string;
                }


                if (btnReset.Text == "STOP")
                {
                    if (str[char_no].ToString() == " " || str[char_no].ToString() == "।" || str[char_no].ToString() == "!" || str[char_no].ToString() == "," || str[char_no].ToString() == "?" || str[char_no] == 0x9CD)//SPACE
                    {
                        internal_character = 0;
                        internal_preceding_vowel = 0;
                        music = engine.Play2D("SOUND//SPACE.wav", false, false, StreamMode.AutoDetect, true);
                        music.Volume = .01f * volume.Value;
                        music.PlaybackSpeed = 0.2f * tempo.Value;
                        while (music.Finished == false) ;
                    }
                    else if (str[char_no] >= 0x985 && str[char_no] <= 0x994)//START WITH VOWEL start/// A O OU AT  AM AM 
                    {
                        if ((str[char_no + 2] < 0x9BE && str[char_no + 1] >= 0X995) || (str[char_no + 2] > 0x9CC))//AT  AM AM/
                        {
                            play_string = str.Substring(char_no, 2);
                            char_no += 1;
                            play_string = det_con_obj.convert(play_string);
                            play_string = play_string + ".mp3";
                            // play a sound file
                            //  MessageBox.Show(play_string);
                            music = engine.Play2D("SOUND//" + play_string, false, false, StreamMode.AutoDetect, true);
                            music.Volume = .1f * volume.Value; music.PlaybackSpeed = 0.2f * tempo.Value;
                            while (music.Finished == false) ;//   while(music.Finished==false);
                            internal_character = 1;
                        }
                        else //A O 
                        {

                            play_string = str[char_no].ToString();
                            play_string = det_con_obj.convert(play_string);
                            play_string = play_string + ".mp3";
                            // play a sound file
                            music = engine.Play2D("SOUND//" + play_string, false, false, StreamMode.AutoDetect, true);
                            //music.Volume = .1f * volume.Value; 
                            music.PlaybackSpeed = 0.2f * tempo.Value;
                            while (music.Finished == false) ;
                            internal_character = 1;
                        }
                    }//////////////////////////////////START WITH VOWEL END 
                    else if (str[char_no] >= 0x995 || str[char_no] <= 0x9B9)/// KO to HO KA TO HA START WITH CONSONANT
                    {
                        if (str[char_no + 1] >= 0x9BE && str[char_no + 1] <= 0x9CC)////KA PA HA
                        {
                            play_string = str.Substring(char_no, 2);
                            char_no++;
                            play_string = det_con_obj.convert(play_string);
                            play_string = play_string + ".mp3";

                            // play a sound file
                            music = engine.Play2D("SOUND//" + play_string, false, false, StreamMode.AutoDetect, true);
                            fx = music.SoundEffectControl;
                            music.Volume = .1f * volume.Value;
                            music.PlaybackSpeed = 0.2f * tempo.Value;
                            while (music.Finished == false) ;
                            internal_character = 1;
                        }////KA PA HA end
                        else //KO HO MO
                        {

                            if (char_no != 0 && str[char_no - 1] >= 0x9BE && str[char_no - 1] <= 0x9CC)//AK OK  KAK 
                            {
                                fx = music.SoundEffectControl; 
                                ch = str[char_no - 1];
                                integer = ch - 0x38;
                                ch = (char)integer;
                                ch.ToString();
                                play_string = ch + str[char_no].ToString();
                                play_string = det_con_obj.convert(play_string);
                                play_string = play_string + ".mp3";
                                music.Volume = .01f;
                                music.PlaybackSpeed = 0.2f * tempo.Value;
                                music.PlayPosition = (uint)180;
                                music = engine.Play2D("SOUND//" + play_string, false, false, StreamMode.AutoDetect, true);
                                
                                music.Volume = .01f;
                                Thread.Sleep(80);
                               music.Volume = .03f;
                                Thread.Sleep(50);
                                music.Volume = .08f;
                                Thread.Sleep(50);
                                music.Volume = .09f;
                                Thread.Sleep(50);
                                music.Volume = .01f;
                                while (music.Finished == false) ;
                            }
                            else //KO HO 
                            {

                                play_string = str[char_no].ToString();
                                play_string = det_con_obj.convert(play_string);
                                play_string = play_string + ".mp3";
                                music = engine.Play2D("SOUND//" + play_string, false, false, StreamMode.AutoDetect, true);
                                music.Volume = .1f * volume.Value;

                                music.PlaybackSpeed = 0.2f * tempo.Value;

                                while (music.Finished == false) ;

                            }
                        }
                    }    ////KO HO KA HA END              
                }
            }

            play_position.Value = 0;
            play_position.Minimum = 0;
            // MessageBox.Show("END !");

            btnReset.Text = "READ";
        }
    }
}