using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameFramework;
using GameFramework.Enum;
using GameFramework.Movement;
using EZInput;
using GameFramework.BL;

namespace GameProject
{
    public partial class Form1 : Form
    {
       
        public static Game game;
        public static int Score;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = Game.GetInstance(this);
            System.Drawing.Point boundary= new System.Drawing.Point(this.Width-100,this.Height-100);
            game.AddGameObject(Properties.Resources.Player2,GameObjectType.Player, 400,400, new KeyBoardMovement(10, boundary));
            game.AddGameObject(Properties.Resources.enemy1,GameObjectType.Enemy,( this.Width-100),0, new VerticalPatrol(5, boundary, Direction.Down));
            game.AddGameObject(Properties.Resources.Enemy3, GameObjectType.Enemy,( this.Width/2+20),10, new ZigZagPatrol(5, boundary, Direction.Down));
            CollisionDetection collisionDetection2 = new CollisionDetection(GameObjectType.PlayerFire, GameObjectType.Enemy, CollisionAction.Kill);
            CollisionDetection collisionDetection1 = new CollisionDetection(GameObjectType.Player,GameObjectType.Enemy,CollisionAction.DecreaseHealth);
            CollisionDetection collisionDetection3 = new CollisionDetection(GameObjectType.EnemyFire, GameObjectType.Player, CollisionAction.DecreasePlayerHealthByBullet);
            CollisionDetection collisionDetection4 = new CollisionDetection(GameObjectType.EnemyFire, GameObjectType.PlayerFire, CollisionAction.Kill);


            game.AddCollisionDetection(collisionDetection1);
            game.AddCollisionDetection(collisionDetection2);
            game.AddCollisionDetection(collisionDetection3);
            game.AddCollisionDetection(collisionDetection4);

        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.Space))
            { 
                 game.FirePlayer(Properties.Resources.Player_Bullet);
            }
            game.RemoveGameObject();
            game.update();
            Score = ((game.GetEnemiesCount() - game.GetCurrentEnemiesCount()) * 100);
            scoreLabel.Text = Score.ToString();
            if (game.GetCurrentEnemiesCount() == 0 || game.GetCurrentPlayersCount() == 0)
            {
                this.Controls.Clear();
                this.Close();
                GameOver Gameover = new GameOver();
                Gameover.Show();
            }
        }

        private void EnemyLoop_Tick(object sender, EventArgs e)
        {
           game.FireEnemy(Properties.Resources.Player_Bullet);
        }
    }
}
