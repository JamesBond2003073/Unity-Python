using UnityEngine;

namespace Exodrifter.UnityPython.Examples
{
	public class PythonUnityHelloWorld : MonoBehaviour
	{
		void Start()
		{
			var engine = global::UnityPython.CreateEngine();
			var scope = engine.CreateScope();

			string code = "import UnityEngine\nUnityEngine.Debug.Log('Hello world!')\nstr = 'Hello world!'"; 
		//	code += "UnityEngine.Debug.Log('Hello world!')";

			var source = engine.CreateScriptSourceFromString(code);
			source.Execute(scope);
			Debug.Log(scope.GetVariable<string>("str"));
		}
	}
}