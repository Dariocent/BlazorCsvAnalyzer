# BlazorCsvAnalyzer

## Description
This software was written using the ASP.NET Core framework Blazor. <br/>
It accepts in input a CSV file containing information about Industrial PCs (Name, avg/min/max
value, CPUMhz). <br/>
It returns a list of Industrial PCs that can be downsized based on their usage. This list can be
downloaded as a text file.
## Functions
1. The first function loads the csv files inputted by the user and checks the validity of the data
that will be processed.
2. The second function groups all the data by IPC id and computes metrics that are used to
determine if a certain IPC can be downsized. The metrics are average usage, 95percentile
usage, standard deviation and the coefficient of variation. <br/>
• The Percentile function calculates the value at a specific percentile within a given
sequence of numerical values. It performs linear interpolation between the closest ranks
to determine the percentile value. <br/>
3. There are numerous ways to decide if an Industrial PC can be downsized. In this tool an
Industrial PC is deemed downsizable if all of these three conditions are satisfied. <br/>
• average usage ≤ 50% <br/>
• 95 percentile usage ≤ 75% <br/>
• coefficient of variation σ/μ ≤ 0.5 <br/>
4. If the Industrial PC is deemed downsizable it is added to the list and sorted.

## Example
IPC;Data Factory;time;AvgValue;MinValue;MaxValue;MetricId;CpuMHz 			 <br/>
ITLT4301;1;01/05/2021;98	94437496;29	34354523;673	0675687;CpuUsageMHz;5600 <br/>
ITLT4301;1;02/05/2021;114	6709829;30	26053102;840	875968;CpuUsageMHz;5600 <br/>
ITLT4301;1;03/05/2021;121	0612276;32	09450259;906	8989447;CpuUsageMHz;5600 <br/>
ITLT4301;1;04/05/2021;119	882602;33	92847417;690	4902987;CpuUsageMHz;5600 <br/>
ITLT4301;1;05/05/2021;125	2555738;35	76244575;728	086716;CpuUsageMHz;5600 <br/>
