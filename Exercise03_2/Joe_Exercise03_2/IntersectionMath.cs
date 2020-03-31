namespace Joe_Exercise03_2
{
    class IntersectionMath
    {
        public static void FindIntersection(
            LineSegment line1, LineSegment line2,
            out bool lines_intersect, out bool segments_intersect,
            out Point intersection)
        {
            double dx12 = line1.p2.X - line1.p1.X;
            double dy12 = line1.p2.Y - line1.p1.Y;
            double dx34 = line2.p2.X - line2.p1.X;
            double dy34 = line2.p2.Y - line2.p1.Y;

            // Solve for t1 and t2
            double denominator = (dy12 * dx34 - dx12 * dy34);

            double t1 = ((line1.p1.X - line2.p1.X) * dy34 + (line2.p1.Y - line1.p1.Y) * dx34) / denominator;

            if (double.IsInfinity(t1))
            {
                // The lines are parallel (or close enough to it).
                lines_intersect = false;
                segments_intersect = false;
                intersection = new Point(float.NaN, float.NaN);
                return;
            }
            lines_intersect = true;

            double t2 = ((line2.p1.X - line1.p1.X) * dy12 + (line1.p1.Y - line2.p1.Y) * dx12) / -denominator;

            // Find the point of intersection.
            intersection = new Point(line1.p1.X + dx12 * t1, line1.p1.Y + dy12 * t1);

            // The segments intersect if t1 and t2 are between 0 and 1.
            segments_intersect =
                ((t1 >= 0) && (t1 <= 1) &&
                (t2 >= 0) && (t2 <= 1));

            // Find the closest points on the segments.
            if (t1 < 0)
            {
                t1 = 0;
            }
            else if (t1 > 1)
            {
                t1 = 1;
            }

            if (t2 < 0)
            {
                t2 = 0;
            }
            else if (t2 > 1)
            {
                t2 = 1;
            }
        }
    }

    class LineSegment
    {
        public Point p1;
        public Point p2;
        public LineSegment(Point _p1, Point _p2)
        {
            p1 = _p1;
            p2 = _p2;
        }
    }

    class Point{
        public double X;
        public double Y;
        public Point(double _X, double _Y)
        {
            X = _X;
            Y = _Y;
        }
    }
}