using System;
class Ex28
{
    static void Main()
    {
        Console.WriteLine("三角柱の体積と表面積を求めます");
        Console.WriteLine("どちらの求め方でやりますか？" +
            "\n1:底面⊿の底辺の長さ+底面⊿の高さ+柱の高さ" +
            "\n2:底面⊿の3辺の長さ+柱の高さ"+
            "\n１か２で答えて下さい");
        var num = int.Parse(Console.ReadLine());

        //三角柱１の計算
        if (num == 1)
        {
            TriangularPrism1 triangularPrism1 = new TriangularPrism1
                (InputFloat("底面⊿の底辺の長さ:"),
            InputFloat("底面⊿の高さ:"),
            InputFloat("柱の高さ:"));
            Console.WriteLine($"表面積は{triangularPrism1.GetSurface1()}");
            Console.WriteLine($"体積は{triangularPrism1.GetVolume1()}");
        }
        //三角柱２の計算
        else
        if (num == 2)
        {
            TriangularPrism2 triangularPrism2 = new TriangularPrism2
            (InputFloat("辺の長さ1:"), InputFloat("辺の長さ2:"),
             InputFloat("辺の長さ3:"), InputFloat("柱の高さ:"));
            Console.WriteLine($"表面積は{triangularPrism2.GetSurface2()}");
            Console.WriteLine($"体積は{triangularPrism2.GetVolume2()}");
        }
        //それ以外はエラー
        else
        {
            Console.WriteLine("エラー");
        }
    }
    static float InputFloat(string outputstring)
    {
        float input;
        while (true)
        {
            Console.Write(outputstring);
            if (float.TryParse(Console.ReadLine(), out input))
            {
                return input;
                Console.WriteLine("エラー");
            }
        }
    }
    //三角柱１の式
    class TriangularPrism1
    {
        private float triangleBottom, triangleHeight, height;
        public TriangularPrism1(float triangleHeight, float triangleBottom, float height)
        {
            this.triangleHeight = triangleHeight;
            this.triangleBottom = triangleBottom;
            this.height = height;
        }
        //表面積
        public float GetSurface1()
        {
            return (float)((triangleHeight * triangleBottom / 2) * 2 + (triangleHeight * height
                + triangleBottom * height
                + Math.Sqrt(triangleHeight * triangleHeight + triangleBottom * triangleBottom) * height));
        }
        //体積
        public float GetVolume1()
        {
            return (triangleHeight * triangleBottom / 2) * height;
        }

    }
    //三角柱２の式
    class TriangularPrism2
    {
        private float side1, side2, side3, height;
        public TriangularPrism2(float side1, float side2, float side3, float height)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.height = height;
        }
        //表面積
        public float GetSurface2()
        {
            return (float)(Math.Sqrt((side1 + side2 + side3) / 2) * height)
                * 2 + (side1 + side2 + side3) * height;
        }
        //体積
        public float GetVolume2()
        {
            return (float)(Math.Sqrt((side1 + side2 + side3) / 2)) * height;
        }
    }
   
}