using Autodesk.AutoCAD.Runtime;
using Aaa =Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.ApplicationServices;
using Core.MyAutoCadAPI;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;
using System;
using Autodesk.AutoCAD.PlottingServices;

namespace Core
{
    public class MyCommands
    {
        Provider provider = new Provider();
        [CommandMethod("-SMXHYPERLINK")]
        public void SMXHYPERLINK()
        {
            Document doc = Aaa.Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor edt = doc.Editor;
            PromptKeywordOptions mainOption = new PromptKeywordOptions("");
            mainOption.Message = "\nEnter an option";
            mainOption.Keywords.Add("Remove");
            mainOption.Keywords.Add("Insert");
            //mainOption.AllowNone = false;
            mainOption.Keywords.Default = "Insert";
            PromptResult promptResult = doc.Editor.GetKeywords(mainOption);
            if (promptResult.StringResult.Equals("Insert"))
            {
                PromptKeywordOptions insertOption = new PromptKeywordOptions("");
                insertOption.Message = "\nEnter hyperlink insert option";
                insertOption.Keywords.Add("Area");
                insertOption.Keywords.Add("Object");
                insertOption.Keywords.Default = "Object";
                promptResult = doc.Editor.GetKeywords(insertOption);
            }
            if (promptResult.StringResult.Equals("Remove"))
            {
                PromptSelectionResult selectionResult = edt.GetSelection();

                if (selectionResult.Status == PromptStatus.OK)
                {
                    using (Transaction transaction = doc.TransactionManager.StartTransaction())
                    {
                        SelectionSet selectionSet = selectionResult.Value;

                        foreach (SelectedObject selectedObject in selectionSet)
                        {
                            if (selectedObject != null)
                            {
                                // Access the selected object
                                ObjectId objectId = selectedObject.ObjectId;
                                Entity entity = transaction.GetObject(objectId, OpenMode.ForRead) as Entity;

                                if (entity != null)
                                {
                                    // You can perform operations on the selected object here
                                    edt.WriteMessage("Selected object type: " + entity.GetType().Name + "\n");
                                }
                            }
                        }

                        transaction.Commit();
                    }
                }
                else
                {
                    edt.WriteMessage("No objects selected.");
                }
            }
        }
        [CommandMethod("getACadFields")]
        public void GetACadFields()
        {
            Document doc = Aaa.Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor edt = doc.Editor;


            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                try
                {
                    var plotConfig = PlotConfigManager.SetCurrentConfig("None");
                    var list = new List<string>();
                    foreach (var item in plotConfig.CanonicalMediaNames)
                    { 

                        list.Add(plotConfig.GetLocalMediaName(item));
                    }


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

    }
}
