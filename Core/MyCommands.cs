using Autodesk.AutoCAD.Runtime;
using Aaa =Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.ApplicationServices;
using Core.MyAutoCadAPI;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Core
{
    public class MyCommands
    {
        Provider provider = new Provider();
        [CommandMethod("getACadFields")]
        public void GetACadFields()
        {
            Document doc = Aaa.Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor edt = doc.Editor;
            string drawingName = "";
            string layoutname = "";


            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                try
                {
                    edt.WriteMessage($"\nGetProperties ACAD");
                    int lastSlashIndex = doc.Name.LastIndexOf("\\");
                    string result = doc.Name.Substring(lastSlashIndex+1, doc.Name.Length- (lastSlashIndex+1));
                    int lastDashIndex = result.LastIndexOf(".");
                    drawingName = result.Substring(0, lastDashIndex);
                    string layoutName = LayoutManager.Current.CurrentLayout;
                    var psv = PlotSettingsValidator.Current;
                    transaction.Commit();

                }
                catch (System.Exception ex)
                {
                    edt.WriteMessage("Error encountered: " + ex.Message);
                    transaction.Abort();
                }
            }
        }

        [CommandMethod("drawingpline")]
        public void DrawingPline()
        {
            Aaa.Document doc = Aaa.Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor edt = doc.Editor;
            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                try
                {
                    edt.WriteMessage($"\nDrawing Pline Exercies: ");
                    BlockTable bt = transaction.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                    BlockTableRecord modelspace = transaction.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                    //send a message to the user
                    edt.WriteMessage($"\nDrawing a Pline object: ");
                    List<Point2d> points = new List<Point2d>();
                    points.Add(new Point2d(0,0));
                    points.Add(new Point2d(2, 0));
                    points.Add(new Point2d(2, 2));
                    points.Add(new Point2d(0, 2));
                    points.Add(new Point2d(0, 0));

                    Polyline pline = provider.PlineRepository.CreatePline(transaction, modelspace, points);
                    transaction.Commit();

                }
                catch (System.Exception ex)
                {
                    edt.WriteMessage("Error encountered: " + ex.Message);
                    transaction.Abort();
                }
            }
        }

        [CommandMethod("drawingarc")]
        public void DrawingArc()
        {
            Aaa.Document doc = Aaa.Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor edt = doc.Editor;
            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                try
                {
                    edt.WriteMessage($"\nDrawing Arc Exercies: ");
                    BlockTable bt = transaction.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                    BlockTableRecord modelspace = transaction.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                    //send a message to the user
                    edt.WriteMessage($"\nDrawing a Arc object: ");
                    Point3d originPoint = new Point3d(0, 0, 0);
                    double arcRad = 20.0;
                    double startAngle = 1.0;
                    double endAngle = 3.0;

                    Arc circle = provider.ArcRepository.CreateCirleWithRadius(transaction, modelspace, originPoint, arcRad,startAngle,endAngle);
                    transaction.Commit();

                }
                catch (System.Exception ex)
                {

                    edt.WriteMessage("Error encountered: " + ex.Message);
                    transaction.Abort();
                }
            }
        }

        [CommandMethod("drawingcircle")]
        public void DrawingCircle()
        {
            Aaa.Document doc = Aaa.Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor edt = doc.Editor;
            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                try
                {
                    edt.WriteMessage($"\nDrawing Circle Exercies: ");
                    BlockTable bt = transaction.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                    BlockTableRecord modelspace = transaction.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                    //send a message to the user
                    edt.WriteMessage($"\nDrawing a Circle object: ");
                    Point3d originPoint = new Point3d(0, 0, 0);
                    double radius = 1000.0;
                    Circle circle = provider.CircleRepository.CreateCirleWithRadius(transaction, modelspace, originPoint, radius);
                    transaction.Commit();

                }
                catch (System.Exception ex)
                {

                    edt.WriteMessage("Error encountered: " + ex.Message);
                    transaction.Abort();
                }
            }
        }

        [CommandMethod("drawingtext")]
        public void DrawingText()
        {
            Aaa.Document doc = Aaa.Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor edt = doc.Editor;
            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                try
                {
                    edt.WriteMessage($"\nDrawing MText Exercies: ");
                    BlockTable bt = transaction.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                    BlockTableRecord modelspace = transaction.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                    //send a message to the user
                    edt.WriteMessage($"\nDrawing a MText object: ");
                    string text = "Hello AutoCad from C#!";
                    Point3d originPoint = new Point3d(0, 0, 0);
                    MText mtx = provider.MtextRepository.CreateMtext(transaction, modelspace, originPoint, text);


                    transaction.Commit();

                }
                catch (System.Exception ex)
                {

                    edt.WriteMessage("Error encountered: " + ex.Message);
                    transaction.Abort();
                }
            }
        }

        [CommandMethod("drawingline")]
        public void DrawingLine()
        {
            Aaa.Document doc = Aaa.Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor edt = doc.Editor;
            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                try
                {
                    edt.WriteMessage($"\nDrawing a Line Excerice: ");
                    BlockTable bt;
                    bt = transaction.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                    BlockTableRecord ModelSpace = transaction.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                    //send a message to the user
                    edt.WriteMessage($"\nDrawing a Line object: ");
                    Point3d pt1 = new Point3d(0,0,0);
                    Point3d pt2 = new Point3d(100,100,0);
                    Line ln = provider.LineRepository.CreateLine3d(transaction, ModelSpace,pt1, pt2);
                    transaction.Commit();

                }
                catch (System.Exception ex)
                {

                    edt.WriteMessage("Error encountered: " + ex.Message);
                    transaction.Abort();
                }
            }
        }

        [CommandMethod("testwinform")]
        public void TestWinform()
        {
            MainForm mainform = new MainForm();
            mainform.ShowDialog();
            
        }

        //[CommandMethod("DeleteObjectOnClick")]
        //public void DeleteObjectOnClick()
        //{
        //    Document doc =Aaa.Application.DocumentManager.MdiActiveDocument;
        //    Editor editor = doc.Editor;

        //    // Prompt the user to select an object to delete
        //    PromptEntityOptions promptOptions = new PromptEntityOptions("\nSelect an object to delete: ");
        //    promptOptions.SetRejectMessage("\nInvalid selection. Please select an object.");
        //    promptOptions.AddAllowedClass(typeof(Line), true);

        //    PromptEntityResult promptResult = editor.GetEntity(promptOptions);

        //    if (promptResult.Status == PromptStatus.OK)
        //    {
        //        ObjectId objectId = promptResult.ObjectId;

        //        // Start a transaction to delete the selected object
        //        using (Transaction transaction = doc.Database.TransactionManager.StartTransaction())
        //        {
        //            Entity entityToDelete = transaction.GetObject(objectId, OpenMode.ForWrite) as Entity;

        //            if (entityToDelete != null)
        //            {
        //                entityToDelete.Erase();
        //                transaction.Commit();
        //                editor.WriteMessage("\nThe selected object has been deleted.");
        //            }
        //            else
        //            {
        //                editor.WriteMessage("\nFailed to open the selected object.");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        editor.WriteMessage("\nNo valid object selected for deletion.");
        //    }
        //}

        //[CommandMethod("DeleteSelected")]
        //public void DeleteSelected()
        //{
        //    Document doc =Aaa.Application.DocumentManager.MdiActiveDocument;
        //    Editor editor = doc.Editor;

        //    // Prompt the user to select objects to delete
        //    PromptSelectionOptions selectionOptions = new PromptSelectionOptions();
        //    selectionOptions.MessageForAdding = "Select objects to delete: ";

        //    PromptSelectionResult selectionResult = editor.GetSelection(selectionOptions);

        //    if (selectionResult.Status == PromptStatus.OK)
        //    {
        //        // Build a list of object IDs from the selection result
        //        ObjectId[] objectIds = selectionResult.Value.GetObjectIds();

        //        // Start a transaction
        //        using (Transaction transaction = doc.Database.TransactionManager.StartTransaction())
        //        {
        //            foreach (ObjectId objectId in objectIds)
        //            {
        //                // Open each selected object for write
        //                DBObject dbObject = transaction.GetObject(objectId, OpenMode.ForWrite);

        //                // Ensure that the object is not null and can be erased
        //                if (dbObject != null && dbObject.IsWriteEnabled)
        //                {
        //                    // Erase the object
        //                    dbObject.Erase();
        //                }
        //            }

        //            // Commit the transaction
        //            transaction.Commit();

        //            // Execute the "DELETE" command to remove deleted objects from the selection set
        //            Aaa.Application.DocumentManager.MdiActiveDocument.SendStringToExecute("_DELETE\n", true, false, true);

        //            // Optionally, you can also send the "_PURGE" command to purge deleted objects
        //            // Application.DocumentManager.MdiActiveDocument.SendStringToExecute("_PURGE\n", true, false, true);
        //        }
        //    }
        //    else
        //    {
        //        editor.WriteMessage("\nNo objects selected for deletion.");
        //    }
        //}
    }
}
