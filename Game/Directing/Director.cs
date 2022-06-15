///directing class for CSE210 greed game. -Eric Poole
using CSE210_Greed.Game.Services;
using CSE210_Greed.Game.Casting;

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

            // Actor banner = cast.GetFirstActor("banner");
            Actor robot = cast.GetFirstActor("robot");
            List<Actor> artifacts = cast.GetActors("artifacts");

            // banner.SetText("");
            int maxX = videoService.GetWidth();
            int maxY = videoService.GetHeight();
            robot.MoveNext(maxX, maxY);

            // foreach (Actor actor in artifacts)
            // {
            //     if (robot.GetPosition().Equals(actor.GetPosition()))
            //     {
            //         Artifact artifact = (Artifact) actor;
            //         if (Artifact.GetIntention() = bad){
            //             // points equals minus one
            //         }
            //         if (Artifact.GetIntention() = good){
            //             // points equal plus one
            //         }
            //     }
            // } 

        }
        public void PushOutputs(Cast cast){

            List<Actor> actors = cast.GetAllActors();
            videoService.ClearBuffer();
            videoService.DrawActors(actors);
            videoService.FlushBuffer();

        }
    }
}