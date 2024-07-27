using GameFramework.BL;
using GameFramework.Enum;
using GameFramework.Interface;
using GameFramework.Movement;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    public class Game
    {
        private Form FormReference;
        private List<GameObject> GameObjects;
        private List<CollisionDetection> CollisionDetections;
        private static Game Instance;
        private int PlayerCount;
        private int EnemyCount;
        private int FireTurn;
        private int fireCount;

        public Game(Form form)
        {
            this.FormReference = form;
            GameObjects = new List<GameObject>();
            CollisionDetections = new List<CollisionDetection>();
            EnemyCount = 0;
            FireTurn = 0;
            fireCount = 0;
            PlayerCount = 0;
        }
        public static Game GetInstance(Form form)
        {
            if (Instance == null)
            {
                Instance = new Game(form);
            }
            return Instance;
        }
        public void AddGameObject(Image Img,GameObjectType type, int left, int top, IMovement controller)
        {
            if (!(type == GameObjectType.Player && PlayerCount > 0) || (type == GameObjectType.Enemy && EnemyCount > 5))
            {
                if (type == GameObjectType.Player)
                {
                    PlayerCount++;
                }
                else if (type == GameObjectType.Enemy)
                {
                    EnemyCount++;
                }

                GameObject gameObject = new GameObject(this.FormReference, type, Img, left, top, controller);
                GameObjects.Add(gameObject);
                FormReference.Controls.Add(gameObject.Pb);
            }
        }
        public void update()
        {
            foreach (GameObject gameobject in GameObjects)
            {     
                gameobject.update();
                foreach (CollisionDetection collision in CollisionDetections)
                {
                    collision.checkCollision(GameObjects);
                }
            }

        }
        public void AddCollisionDetection(CollisionDetection collision)
        {
            CollisionDetections.Add(collision);
        }
        public void FirePlayer(Image img)
        {
            int left = 0, top = 0;
            foreach (GameObject gameobject in GameObjects)
            {
                if (gameobject.GetGameObjectType() == GameObjectType.Player)
                {
                    left = gameobject.Pb.Left + gameobject.Pb.Width;
                    top = (gameobject.Pb.Top) + (gameobject.Pb.Height / 2);
                    break;
                }
            }
            AddGameObject(img, GameObjectType.PlayerFire, left, top, new FireMovement(20, new Point(FormReference.Width, FormReference.Height), Direction.Right));
        }
        public void FireEnemy(Image img)
        {
            List<GameObject> Enemies = new List<GameObject>();
            int left = 0, top = 0;
            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObject gameobject = GameObjects[i];
                if (gameobject.GetGameObjectType() == GameObjectType.Enemy)
                {
                    Enemies.Add(gameobject);
                }
            }
            if (Enemies != null && Enemies.Count > FireTurn)
            {
                GameObject enemy = Enemies[FireTurn % 4];
                left = enemy.Pb.Left - 3;
                top = (enemy.Pb.Top) + (enemy.Pb.Height / 2);
                if (fireCount == 10)
                {
                    AddGameObject(img, GameObjectType.EnemyFire, left, top, new FireMovement(10, new Point(FormReference.Width, FormReference.Height), Direction.Left));
                    fireCount = 0;
                }
                else
                    fireCount++;
            }
            else if (Enemies.Count != 0)
            {
                FireTurn--;
            }

        }


        public void RemoveGameObject()
        {
            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObject gameobject = GameObjects[i];
                if (gameobject.GetHealth() == 0 || gameobject.Pb.Location.X > FormReference.Width || gameobject.Pb.Location.Y > FormReference.Height)
                {
                    if (gameobject.HealthBar != null)
                    {
                        FormReference.Controls.Remove(gameobject.HealthBar);
                    }
                    GameObjects.Remove(gameobject);
                    FormReference.Controls.Remove(gameobject.Pb);


                }
            }
        }
        public int GetEnemiesCount()
        {
            return EnemyCount;
        }
        public int GetCurrentEnemiesCount()
        {
            List<GameObject> Enemies = new List<GameObject>();

            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObject gameobject = GameObjects[i];
                if (gameobject.GetGameObjectType() == GameObjectType.Enemy)
                {
                    Enemies.Add(gameobject);
                }
            }
            return Enemies.Count;
        }
        public int GetCurrentPlayersCount()
        {
            List<GameObject> Players = new List<GameObject>();

            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObject gameobject = GameObjects[i];
                if (gameobject.GetGameObjectType() == GameObjectType.Player)
                {
                    Players.Add(gameobject);
                }
            }
            return Players.Count;
        }

    }
}
