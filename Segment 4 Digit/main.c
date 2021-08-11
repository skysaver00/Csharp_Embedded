/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
  ******************************************************************************
  * @attention
  *
  * <h2><center>&copy; Copyright (c) 2021 STMicroelectronics.
  * All rights reserved.</center></h2>
  *
  * This software component is licensed by ST under BSD 3-Clause license,
  * the "License"; You may not use this file except in compliance with the
  * License. You may obtain a copy of the License at:
  *                        opensource.org/licenses/BSD-3-Clause
  *
  ******************************************************************************
  */
/* USER CODE END Header */
/* Includes ------------------------------------------------------------------*/
#include "main.h"
#include "usart.h"
#include "gpio.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */

/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */

/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */
#define D1_HIGH() HAL_GPIO_WritePin(D1_GPIO_Port, D1_Pin, GPIO_PIN_SET)
#define D1_LOW() HAL_GPIO_WritePin(D1_GPIO_Port, D1_Pin, GPIO_PIN_RESET)
#define D2_HIGH() HAL_GPIO_WritePin(D2_GPIO_Port, D2_Pin, GPIO_PIN_SET)
#define D2_LOW() HAL_GPIO_WritePin(D2_GPIO_Port, D2_Pin, GPIO_PIN_RESET)
#define D3_HIGH() HAL_GPIO_WritePin(D3_GPIO_Port, D3_Pin, GPIO_PIN_SET)
#define D3_LOW() HAL_GPIO_WritePin(D3_GPIO_Port, D3_Pin, GPIO_PIN_RESET)
#define D4_HIGH() HAL_GPIO_WritePin(D4_GPIO_Port, D4_Pin, GPIO_PIN_SET)
#define D4_LOW() HAL_GPIO_WritePin(D4_GPIO_Port, D4_Pin, GPIO_PIN_RESET)
/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/

/* USER CODE BEGIN PV */
uint32_t seg_ptn[10] = {0x3f, 0x06, 0x5b, 0x4f, 0x66, 0x6d, 0x7d, 0x07, 0x7f, 0x6f};
uint32_t k = 0;
int ck = 0, num = 0, val, die;
int temp1, temp10, temp100, temp1000;
extern int Run, Run2;
/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */
void HAL_GPIO_EXTI_Callback(uint16_t GPIO_Pin) {
  /*if(GPIO_Pin == BTN2_Pin) {
    k++;
    HAL_GPIO_TogglePin(LD2_GPIO_Port, LD2_Pin);
    HAL_GPIO_TogglePin(LD3_GPIO_Port, LD3_Pin);
    HAL_GPIO_TogglePin(LD4_GPIO_Port, LD4_Pin);
    HAL_GPIO_TogglePin(LD5_GPIO_Port, LD5_Pin);
  }*/
  
  if(GPIO_Pin == BTN_Pin) {
    k++;
    HAL_GPIO_TogglePin(LD2_GPIO_Port, LD2_Pin);
    HAL_GPIO_TogglePin(LD3_GPIO_Port, LD3_Pin);
    HAL_GPIO_TogglePin(LD4_GPIO_Port, LD4_Pin);
    HAL_GPIO_TogglePin(LD5_GPIO_Port, LD5_Pin);
  }
}

void SevenSegment_1(int val) {
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGA_GPIO_Port, SEGA_Pin, SET);
  else HAL_GPIO_WritePin(SEGA_GPIO_Port, SEGA_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGB_GPIO_Port, SEGB_Pin, SET);
  else HAL_GPIO_WritePin(SEGB_GPIO_Port, SEGB_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGC_GPIO_Port, SEGC_Pin, SET);
  else HAL_GPIO_WritePin(SEGC_GPIO_Port, SEGC_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGD_GPIO_Port, SEGD_Pin, SET);
  else HAL_GPIO_WritePin(SEGD_GPIO_Port, SEGD_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGE_GPIO_Port, SEGE_Pin, SET);
  else HAL_GPIO_WritePin(SEGE_GPIO_Port, SEGE_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGF_GPIO_Port, SEGF_Pin, SET);
  else HAL_GPIO_WritePin(SEGF_GPIO_Port, SEGF_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGG_GPIO_Port, SEGG_Pin, SET);
  else HAL_GPIO_WritePin(SEGG_GPIO_Port, SEGG_Pin, RESET);
}

void SevenSegment_10(int val) {
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGA_GPIO_Port, SEGA_Pin, SET);
  else HAL_GPIO_WritePin(SEGA_GPIO_Port, SEGA_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGB_GPIO_Port, SEGB_Pin, SET);
  else HAL_GPIO_WritePin(SEGB_GPIO_Port, SEGB_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGC_GPIO_Port, SEGC_Pin, SET);
  else HAL_GPIO_WritePin(SEGC_GPIO_Port, SEGC_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGD_GPIO_Port, SEGD_Pin, SET);
  else HAL_GPIO_WritePin(SEGD_GPIO_Port, SEGD_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGE_GPIO_Port, SEGE_Pin, SET);
  else HAL_GPIO_WritePin(SEGE_GPIO_Port, SEGE_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGF_GPIO_Port, SEGF_Pin, SET);
  else HAL_GPIO_WritePin(SEGF_GPIO_Port, SEGF_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGG_GPIO_Port, SEGG_Pin, SET);
  else HAL_GPIO_WritePin(SEGG_GPIO_Port, SEGG_Pin, RESET);
}

void SevenSegment_100(int val) {
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGA_GPIO_Port, SEGA_Pin, SET);
  else HAL_GPIO_WritePin(SEGA_GPIO_Port, SEGA_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGB_GPIO_Port, SEGB_Pin, SET);
  else HAL_GPIO_WritePin(SEGB_GPIO_Port, SEGB_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGC_GPIO_Port, SEGC_Pin, SET);
  else HAL_GPIO_WritePin(SEGC_GPIO_Port, SEGC_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGD_GPIO_Port, SEGD_Pin, SET);
  else HAL_GPIO_WritePin(SEGD_GPIO_Port, SEGD_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGE_GPIO_Port, SEGE_Pin, SET);
  else HAL_GPIO_WritePin(SEGE_GPIO_Port, SEGE_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGF_GPIO_Port, SEGF_Pin, SET);
  else HAL_GPIO_WritePin(SEGF_GPIO_Port, SEGF_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGG_GPIO_Port, SEGG_Pin, SET);
  else HAL_GPIO_WritePin(SEGG_GPIO_Port, SEGG_Pin, RESET);
}

void SevenSegment_1000(int val) {
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGA_GPIO_Port, SEGA_Pin, SET);
  else HAL_GPIO_WritePin(SEGA_GPIO_Port, SEGA_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGB_GPIO_Port, SEGB_Pin, SET);
  else HAL_GPIO_WritePin(SEGB_GPIO_Port, SEGB_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGC_GPIO_Port, SEGC_Pin, SET);
  else HAL_GPIO_WritePin(SEGC_GPIO_Port, SEGC_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGD_GPIO_Port, SEGD_Pin, SET);
  else HAL_GPIO_WritePin(SEGD_GPIO_Port, SEGD_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGE_GPIO_Port, SEGE_Pin, SET);
  else HAL_GPIO_WritePin(SEGE_GPIO_Port, SEGE_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGF_GPIO_Port, SEGF_Pin, SET);
  else HAL_GPIO_WritePin(SEGF_GPIO_Port, SEGF_Pin, RESET);

  val /= 2;
  ck = val % 2;
  if(ck == 1) HAL_GPIO_WritePin(SEGG_GPIO_Port, SEGG_Pin, SET);
  else HAL_GPIO_WritePin(SEGG_GPIO_Port, SEGG_Pin, RESET);
}
/* USER CODE END 0 */

/**
  * @brief  The application entry point.
  * @retval int
  */
int main(void)
{
  /* USER CODE BEGIN 1 */
  /* USER CODE END 1 */

  /* MCU Configuration--------------------------------------------------------*/

  /* Reset of all peripherals, Initializes the Flash interface and the Systick. */
  HAL_Init();

  /* USER CODE BEGIN Init */

  /* USER CODE END Init */

  /* Configure the system clock */
  SystemClock_Config();

  /* USER CODE BEGIN SysInit */

  /* USER CODE END SysInit */

  /* Initialize all configured peripherals */
  MX_GPIO_Init();
  MX_USART2_UART_Init();
  /* USER CODE BEGIN 2 */
  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
    /* USER CODE END WHILE */
    temp1 = Run2 % 10;
    temp10 = (Run2 / 10) % 10;
    temp100 = (Run2 / 100) % 10;
    temp1000 = Run2 / 1000;
    
    SevenSegment_1(temp1);
    D1_LOW();
    HAL_Delay(7);
    D1_HIGH();
    
    SevenSegment_10(temp10);
    D2_LOW();
    HAL_Delay(7);
    D2_HIGH();

    SevenSegment_100(temp100);
    D3_LOW();
    HAL_Delay(7);
    D3_HIGH();

    SevenSegment_1000(temp1000);
    D4_LOW();
    HAL_Delay(7);
    D4_HIGH();

    /*if(Run % 50 == 0 && die == 0) {
      if(num % 10 == 0) num = 1;
      else num++;
      
      val = seg_ptn[num - 1];
      
      HAL_GPIO_WritePin(D1_GPIO_Port, D1_Pin, SET);
      HAL_GPIO_WritePin(D10_GPIO_Port, D10_Pin, SET);
      HAL_GPIO_WritePin(D100_GPIO_Port, D100_Pin, SET);
      HAL_GPIO_WritePin(D1000_GPIO_Port, D1000_Pin, SET);
      
      HAL_GPIO_WritePin(SEGA_GPIO_Port, SEGA_Pin, RESET);
      HAL_GPIO_WritePin(SEGB_GPIO_Port, SEGB_Pin, RESET);
      HAL_GPIO_WritePin(SEGC_GPIO_Port, SEGC_Pin, RESET);
      HAL_GPIO_WritePin(SEGD_GPIO_Port, SEGD_Pin, RESET);
      HAL_GPIO_WritePin(SEGE_GPIO_Port, SEGE_Pin, RESET);
      HAL_GPIO_WritePin(SEGF_GPIO_Port, SEGF_Pin, RESET);
      HAL_GPIO_WritePin(SEGG_GPIO_Port, SEGG_Pin, RESET);
      
      die = 1;
    }*/
    
    if(Run % 50 == 30 && die == 1) die = 0;
    /* USER CODE BEGIN 3 */
  }
  /* USER CODE END 3 */
}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{
  RCC_OscInitTypeDef RCC_OscInitStruct = {0};
  RCC_ClkInitTypeDef RCC_ClkInitStruct = {0};

  /** Configure the main internal regulator output voltage
  */
  __HAL_RCC_PWR_CLK_ENABLE();
  __HAL_PWR_VOLTAGESCALING_CONFIG(PWR_REGULATOR_VOLTAGE_SCALE1);
  /** Initializes the RCC Oscillators according to the specified parameters
  * in the RCC_OscInitTypeDef structure.
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSE;
  RCC_OscInitStruct.HSEState = RCC_HSE_ON;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
  RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSE;
  RCC_OscInitStruct.PLL.PLLM = 13;
  RCC_OscInitStruct.PLL.PLLN = 180;
  RCC_OscInitStruct.PLL.PLLP = RCC_PLLP_DIV2;
  RCC_OscInitStruct.PLL.PLLQ = 2;
  RCC_OscInitStruct.PLL.PLLR = 2;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }
  /** Activate the Over-Drive mode
  */
  if (HAL_PWREx_EnableOverDrive() != HAL_OK)
  {
    Error_Handler();
  }
  /** Initializes the CPU, AHB and APB buses clocks
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV4;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV2;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_5) != HAL_OK)
  {
    Error_Handler();
  }
}

/* USER CODE BEGIN 4 */

/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */
  __disable_irq();
  while (1)
  {
  }
  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
