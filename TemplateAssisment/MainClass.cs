using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateAssisment
{
    public class MainClass
    {
        int Lifelines = 0;
        int Bullet = 6;
        public void WeaponReload()
        // After taking life from spin this class is come to play that give bullets to the player.
        {
            if (Lifelines > 0)
            if (Bullet == 6)            {
                Bullet = 0;
                SoundPlayer sound = new SoundPlayer(TemplateAssisment.Properties.Resources.Reload);
                sound.Play();
                MessageBox.Show("Reloding Weapon");
            }
            else
            {
                MessageBox.Show("Bullets are avaliable");
            }
        }
        public void Shoot()

        //After successful reloading you can play this class
        {
            if (Lifelines > 0)
                
            if (Bullet == 6)
            {
                MessageBox.Show("Game Over !! You Get 6 Points");
            }
            else
            {
                    SoundPlayer sound = new SoundPlayer(TemplateAssisment.Properties.Resources.Bomber);
                    sound.Play();
                    MessageBox.Show("Shoot");
                Bullet = Bullet + 1;
                MessageBox.Show("You Have Point \n " + Bullet +  "\n " );
            }
        }
        public void Forspin()
        // This is the first class that give life to the player before click on this your not able to click other button
        {
            Random rand = new Random();
            Bullet = rand.Next(6, 6);
            Lifelines = 2;
            MessageBox.Show("Your Weapon is spin");
        }
        public void AwayShooting()
        //After successful reloading you can play this class
        {
            if (Bullet < 6)
            {
                if (Lifelines == 0)
                {
                    MessageBox.Show("Game Over !! You Get " + Bullet + " Points");
                }
                else
                {
                    SoundPlayer sound = new SoundPlayer(TemplateAssisment.Properties.Resources.gunsound);
                    sound.Play();
                    Bullet = Bullet + 1;
                    Lifelines = Lifelines - 1;
                    MessageBox.Show("Bullet Away");
                    MessageBox.Show("You Have Point \n " + Bullet + (Bullet == 6 ? "\n " : "\n"));
                }
            }            
        }
    }
}