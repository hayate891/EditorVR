﻿#if UNITY_EDITOR
namespace UnityEditor.Experimental.EditorVR.Core
{
	interface ILateBindInterfaceMethods<T> where T : class
	{
		void LateBindInterfaceMethods(T provider);
	}
}
#endif
