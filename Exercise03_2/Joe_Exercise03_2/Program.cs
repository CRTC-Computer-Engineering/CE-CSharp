using System;
using JoesLib;

namespace Joe_Exercise03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LineSegment line1 = new LineSegment(new Point(jonsole.getUserNumber("Line 1, Point 1, X: "),jonsole.getUserNumber("Line 1, Point 1, Y: ")), new Point(jonsole.getUserNumber("Line 1, Point 2, X: "),jonsole.getUserNumber("Line 1, Point 2, Y: ")));
            LineSegment line2 = new LineSegment(new Point(jonsole.getUserNumber("Line 2, Point 1, X: "),jonsole.getUserNumber("Line 2, Point 1, Y: ")), new Point(jonsole.getUserNumber("Line 2, Point 2, X: "),jonsole.getUserNumber("Line 2, Point 2, Y: ")));

            bool lines_intersect;
            bool segments_intersect;
            Point intersection;

            IntersectionMath.FindIntersection(line1, line2, out lines_intersect, out segments_intersect, out intersection);

            Console.WriteLine(
                @"
                Testing intersection of line ({0}, {1})-({2},{3}) and ({4}, {5})-({6},{7}).
                Intersect?: {8}.
                Segments Intersect?: {9}.
                Intersection location?: ({10}, {11})."
                ,line1.p1.X
                ,line1.p1.Y
                ,line1.p2.X
                ,line1.p2.Y
                ,line1.p1.X
                ,line1.p1.Y
                ,line1.p2.X
                ,line1.p2.Y
                ,lines_intersect
                ,segments_intersect
                ,intersection.X
                ,intersection.Y);
        
            jonsole.enterToContinue();
        }
    }
}
