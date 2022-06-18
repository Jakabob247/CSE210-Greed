///directing class for CSE210 greed game. -Eric Poole
using CSE210_Greed.Game.Services;
using CSE210_Greed.Game.Casting;

namespace CSE210_Greed.Game.Directing{

    public class Director{
        private int POINTS = 0;
        private KeyboardService keyboardService = null;
        private VideoService videoService = null;
        private static int FRAME_RATE = 60;
        private static int MAX_X = 900;
        private static int MAX_Y = 600;
        private static int CELL_SIZE = 15;
        private static int FONT_SIZE = 15;
        private static int COLS = 60;
        private static int ROWS = 40;
        private static string CAPTION = "Greed";
        // private static string DATA_PATH = "Data/messages.txt";
        private static Color WHITE = new Color(255, 255, 255);
        private static int DEFAULT_ARTIFACTS = 40;

        ///Setting the intilisation of the director class.
        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this.keyboardService = keyboardService;
            this.videoService = videoService;
        }

        ///start game function allows you to start game and calls the different aspects of the game.
        public void StartGame(Cast cast){
            videoService.OpenWindow();
            while (videoService.IsWindowOpen()){
                GetInputs(cast);
                SetUpdates(cast);
                PushOutputs(cast);
            }
            videoService.CloseWindow();
        }
        
        // pulls the users inputs
        public void GetInputs(Cast cast){
            // neeeds the cast to input cast
            Actor robot = cast.GetFirstActor("robot");
            // gets keyboard services
            Point velocity = keyboardService.GetDirection();
            // sets the direction for user
            robot.SetVelocity(velocity); 



        }
        public void SetUpdates(Cast cast){
            Actor banner = cast.GetFirstActor("banner");
            Actor robot = cast.GetFirstActor("robot");
            List<Actor> artifacts = cast.GetActors("artifacts");

            int maxX = videoService.GetWidth();
            int maxY = videoService.GetHeight();
            robot.MoveNext(maxX, maxY);

            Random random = new Random();

                string text = ((char)random.Next(33, 126)).ToString();

            foreach (Actor actor in artifacts){
                if (robot.GetPosition().Equals(actor.GetPosition()))
                {
                    Artifact artifact = (Artifact) actor;
                    POINTS += 1;
                    banner.SetText("POINTS:" + POINTS.ToString());
                    banner.SetText("hello wo");
                }
            } 
                int x = random.Next(1, COLS);
                int y = 0;
                Point position = new Point(x, y);
                position = position.Scale(CELL_SIZE);

                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 256);
                Color color = new Color(r, g, b);
                
                // Adds gem to the cast list
                if (random.Next(0, 2) == 1 && cast.GetAllActors().Count <= 60)
                {
                Gem artifact = new Gem();

                artifact.SetFontSize(FONT_SIZE);
                artifact.SetColor(color);
                artifact.SetPosition(position);

                cast.AddActor("artifacts", artifact);
                }
                else if (cast.GetAllActors().Count <= 60)
                {
                // Adds rock to the cast list
                Rock artifact = new Rock();

                artifact.SetFontSize(FONT_SIZE);
                    artifact.SetColor(color);
                artifact.SetPosition(position);

                cast.AddActor("artifacts", artifact);
                }


            foreach(Actor i in cast.GetActors("artifacts"))
            {
                Point direction = new Point(0, 1);
                direction = direction.Scale(CELL_SIZE);

                i.SetVelocity(direction);
                i.MoveNext(maxX, maxY);
            }

        }

        public void PushOutputs(Cast cast){

            List<Actor> actors = cast.GetAllActors();
            videoService.ClearBuffer();
            videoService.DrawActors(actors);
            videoService.FlushBuffer();

        }
    }
}