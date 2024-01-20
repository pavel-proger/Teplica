/*
 * Created by SharpDevelop.
 * User: HP8440P
 * Date: 19.01.2024
 * Time: 11:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SmartStorage
{
	class Program
	{
		public static void Main(string[] args)
		{
			class AutoLightingThermocontrol{
				Switch Control:
                                 Case 0: // Окно открыто
                                 windowOpen = true ;
                                 Break ;
                                 Case 1 // Окно закрыто
                                 Break ;
                                 Case 2 // Включить вентилятор на нагрев
                                 heatFanOn = true ;
                                 Break ;
                                 Case 3 // Включить вентилятор на нагрев с нагревательным элементом
                                 heatFanOn = true ;
                                 heaterOn = true ;
                                 Break ;
                                 Case 4 // Включить вентилятор на охлаждение
                                 coldFanOn = true ;
                                 Break ;
                                 Case 5 // Включить освещение
                                 lightOn = true ;
                                 Break ;
                                 Case 6 // Выключить освещение
                                 lightOn = false ;
                                 Break ;
                                 Case 7 // Включение ПИД регулятора на охлаждение
                                 PIDColdOn = true ;
                                 Break ;
                                 Case 8 // Включение ПИД регулятора на нагрев
                                 PIDHeatOn = true ;
                                 Break ;
                                 Case 9 // Выключить вентилятор и нагревательный элемент, если они были включены
                                 heatFanOn = false ;
                                 heaterOn = false ;
                                 Break ;

				
			}
			
			class AutoWatering{
                               Switch AutoWatering:
				Case 0 // Система готова к поливу
                                tankFull = true ;
				Break ;
				Case 1 // Полив начат
				wateringStart = true ;
				Break ;
				Case 2 // Полив завершен
				wateringStart = false ;
				Break ;
				Case 3 // Начат набор воды в бак
				pumpStart = true ;
				tankFull = false ;
				Break ;
				Case 4 // Завершен набор воды в бак
				pumpStart = false ;
				Break ;

			}
			
			
			}
			
			
			}
			/*
			  * 
			  * 
			  * 
			  * Данный код педоставлен в ознакомительных целях, для конкетного внедрения на определенной системе удет нужна доработка под потребноси этой системы.
			  * This code is provided in acquittal purposes, for a particular implementation on a certain system, refinement will be needed for the need of this system.
			  * 
			  * 
			  * 
			  * */
		}
	}
}