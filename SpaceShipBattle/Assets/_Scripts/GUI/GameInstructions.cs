using UnityEngine;
using System.Collections;

//Responsável por exibir a primeira tela de instruções

public class GameInstructions : MonoBehaviour {
	
	//--->Variáveis
	//Variável que guarda o skin da primeira tela de instruções
	public GUISkin skin;
	
	//--->Função chamada para renderizar e lidar com eventos de GUI
	//http://docs.unity3d.com/Documentation/ScriptReference/MonoBehaviour.OnGUI.html
	void OnGUI ()
	{
		//A skin é setada
		GUI.skin = skin;
		
		//Cria o botão ˝Play˝ e, caso o jogador clique nele...
		if (GUI.Button (new Rect (Screen.width-240, Screen.height-110, 200, 40), "Play")) 
		{	
			//Procura um GameObject chamado Controllers
			GameObject game_object = GameObject.Find ("Controllers");
			//Se este GameObject existe...
			if(game_object)
				//Então ele é destruído
				Destroy(game_object);
			//A cena do jogo propriamente dito é carregada
			Application.LoadLevel ("SpaceShipGame");
		}
		
		//Cria o botão ˝Next˝ e, caso o jogador clique nele...
		if (GUI.Button (new Rect (Screen.width-240, Screen.height-60, 200, 40), "Next")) 
		{	
			//A cena que contém a continuação das instruões é carregada
			Application.LoadLevel ("GameInstructions2");
		}
		//Se a tecla Escape é pressionada, o jogo é abortado
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
