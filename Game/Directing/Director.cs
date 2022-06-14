///directing class for CSE210 greed game. -Eric Poole
namespace CSE210_Greed.Game.Directing{

    public class Director{

        private KeyboardService keyboardService = null;
        private VideoService videoService = null;

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
                GetInputs();
                SetUpdates();
                PushOutputs();
            }
            videoService.CloseWindow();
        }
        
        // pulls the users inputs
        public void GetInputs(){
            // call user
            Actor User = cast.GetFirstActor("user");
            // gets keyboard services
            Point velocity = keyboardService.GetDirection();
            // sets the direction for user
            user.SetVelocity(velocity);     
        }
        public void SetUpdates(){

            Actor banner = cast.GetFirstActor("banner");
            Actor robot = cast.GetFirstActor("robot");
            List<Actor> artifacts = cast.GetActors("artifacts");

            banner.SetText("");
            int maxX = videoService.GetWidth();
            int maxY = videoService.GetHeight();
            User.MoveNext(maxX, maxY);

            foreach (Actor actor in artifacts)
            {
                if (robot.GetPosition().Equals(actor.GetPosition()))
                {
                    Artifact artifact = (Artifact) actor;
                    if (Artifact.GetIntention() = bad){
                        // points equals minus one
                    }
                    if (Artifact.GetIntention() = good){
                        // points equal plus one
                    }
                }
            } 

        }
        public void PushOutputs(){

            List<Actor> actors = cast.GetAllActors();
            videoService.ClearBuffer();
            videoService.DrawActors(actors);
            videoService.FlushBuffer();

        }
    }
}