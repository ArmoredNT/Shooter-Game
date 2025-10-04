public class PlaceObject : global::Command
{
    private Jeff _controller;
    public PlaceObject(Jeff controller)
    {
        _controller = controller;
    }
    
    public override void Execute()
    {
        _controller.Place(); 
    } 
}