# Flight-time-estimation-simulator
Flight time estimation simulator

This project focuses on the princples of decision structures

 * Purpose: To create a program to determine if current estimates of flight times are accurate by comparing the user input of estimated flight time and the actual flight time to see what the acceptable error margin in minutes is. With that, you can then get a consideration whether the estimate is too large, acceptable, or too small.
 * 
 * Input: Estimated flight time in minutes and actual flight time in minutes.
 * 
 * Process: Using the chart table of acceptable error margins, compare what the user inputted and determine your acceptable error margin. To get the acceptable error margin, use the estimated flight time's range such as from 0 to 29 in minutes. If the estimated time is greater 
 * than the actual flight, subtract it from the error of margin. If the estimated time is less than the actual flight, add it with the
 * error of margin. If the actual flight time is less than the estimated time subtracted or added with the error margin, subtract 
 * the actual flight time from the value and the result is deemed as too large. If the actual flight time is greater than the estimated time subtracted or added
 * with the error margin, subtract the actual flight time from the value and the result is deemed as too small. Otherwise, the estimation is 
 * acceptable.
 * 
 * Output: A time estimate that states whether if the estimated flight time is too large, small, or acceptable as well as by how many minutes. 
 * 
 * Author: Kevin Tran
 * 
 * Last Modified: 2019-10-01
