using TetrisApp.GameHelper;

namespace TetrisApp
{
    /// <summary>
    /// bu sınıf tetris şekillerinin yön değiştirmesi içindir.
    /// </summary>
    /// <example>
    /// <code>
    /// 
    /// </code>
    /// </example>
    public class ShapeRotation
    {
        /// <summary>
        /// bu <see cref="_90DegRotateMatrix(byte[,])"/> methodu sekli matris olarak alır ve işler geri döndürür
        /// </summary>
        /// <param name="matrix">2d kare matris örneğini işler ve geri döndürür</param>
        /// <returns></returns>
        public byte[,] _90DegRotateMatrix(byte[,] matrix) //90 derece saga çevirme
        {
            byte[,] NewMatrix = new byte[4, 4];

            for (int i = 3; i >= 0; --i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    NewMatrix[j, 3 - i] = matrix[i, j];
                }
            }
            return NewMatrix;
        }

    }
}
