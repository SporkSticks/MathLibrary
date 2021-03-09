using System;


//---------------------------------
//---------------------------------
namespace MathLib
{
	//---------------------------------
	//---------------------------------
	public struct Vector2
	{
		// Member Variables
		public float x;
		public float y;

		// Constructor
		public Vector2(float x = 0.0f, float y = 0.0f)
		{
			this.x = x;
			this.y = y;
		}

		// V = V + V --> Vector Addition
		public static Vector2 operator+ (Vector2 lhs, Vector2 rhs)
		{
			Vector2 result;
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;

			return result;	
		}

		// V = V - V --> Vector Subtraction
		public static Vector2 operator- (Vector2 lhs, Vector2 rhs)
		{
			Vector2 result;
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;

			return result;
		}

		// V = f * V --> Vector Scaling (float lhs)
		public static Vector2 operator* (Vector2 lhs, float rhs)
		{
			Vector2 result;
			result.x = lhs.x * rhs;
			result.y = lhs.y * rhs;

			return result;
		}

		// V = V * f --> Vector Scaling (float rhs)
		public static Vector2 operator* (float lhs, Vector2 rhs)
		{
			Vector2 result;
			result.x = lhs * rhs.x;
			result.y = lhs * rhs.y;

			return result;
		}

		// f = V.Dot(V) --> Dot Product

		
		// V = V.Cross(V) --> Cross Product


		// f = V.Magnitude() --> Magnitude


		// Normalise()


		// setRotateX(f)


		// setRotateY(f)
	}


	//---------------------------------
	//---------------------------------
	public struct Vector3
	{
		// Member Variables
		public float x;
		public float y;
		public float z;

		public Vector3(float x = 0.0f, float y = 0.0f, float z = 0.0f)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
	}


	//---------------------------------
	//---------------------------------
	public struct Vector4
	{
		// Member Variables
		public float x;
		public float y;
		public float z;
		public float w;

		public Vector4(float x = 0.0f, float y = 0.0f, float z = 0.0f, float w = 0.0f)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}
	}


	//---------------------------------
	//---------------------------------
	public struct Matrix3
	{

	}


	//---------------------------------
	//---------------------------------
	public struct Matrix4
	{

	}


	//---------------------------------
	//---------------------------------
	public struct Colour
	{

	}
}
