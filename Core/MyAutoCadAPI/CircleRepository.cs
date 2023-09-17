using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;


namespace Core.MyAutoCadAPI
{
    public class CircleRepository
    {
        public CircleRepository() { }
        public Circle CreateCirleWithRadius(Transaction transaction, BlockTableRecord modelspace, Point3d originpoint, double radius)
        {
            Circle circle = new Circle();
            circle.Radius = radius;
            circle.Center = originpoint;
            circle.ColorIndex = 1; // Color is red
            modelspace.AppendEntity(circle);
            transaction.AddNewlyCreatedDBObject(circle, true);
            return circle;
        }
    }
}
