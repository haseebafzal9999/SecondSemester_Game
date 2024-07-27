using GameFramework.Enum;
using GameFramework.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    public class GameObject
    {
        internal PictureBox Pb;
        private IMovement Controller;
        private int Health;
        internal ProgressBar HealthBar;
        private GameObjectType Type;

        public GameObject(Form formreference, GameObjectType type, Image img, int left, int top, IMovement Controller)
        {
            Pb = new PictureBox();
            Pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb.BackColor = Color.Transparent;
            Pb.Image = img;
            Pb.Width = img.Width;
            Pb.Height = img.Height;
            Pb.Left = left;
            Pb.Top = top;
            this.Controller = Controller;
            this.Health = 100;
            this.Type = type;
            if (type == GameObjectType.Player)
            {
                HealthBar = new ProgressBar();
                HealthBar.Top = top + 90;
                HealthBar.Left = left+5;
                HealthBar.TabIndex = 0;
                HealthBar.Size = new System.Drawing.Size(80, 13);
                HealthBar.Value = Health;
                formreference.Controls.Add(HealthBar);
            }
        }
        public void update()
        {
            this.Pb.Location = Controller.Move(this.Pb.Location);
            if (HealthBar != null)
            {
                this.HealthBar.Location = Controller.Move(this.HealthBar.Location);
            }
        
    }
        public GameObjectType GetGameObjectType()
        {
            return this.Type;
        }
        public void SetHealth(int health)
        {
            if (health >= 0)
            {
                Health = health;
            }
            else if (health < 0)
            {
                Health = 0;
            }
            if (HealthBar != null)
                this.HealthBar.Value = this.Health;
        }
        public int GetHealth()
        {
            return Health;
        }
        public IMovement GetMovementController()
        {
            return Controller;
        }
    }

}
