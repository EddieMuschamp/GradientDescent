# Gradient Descent for Binary Classification
This project demonstrates a simple implementation of the Gradient Descent algorithm for binary classification using a logistic regression model. The program reads data from a file, applies gradient descent to adjust weights, and prints the results for each epoch.

## Features
* Reads Data: Loads data from data-OR.txt, which should contain input features and expected outputs.
* Gradient Descent: Implements weight adjustment based on the Gradient Descent algorithm to optimize the logistic regression model.
* Epochs: Runs multiple epochs of training for each data line to update weights and print results.

## Code Overview
Contains the main implementation of the Gradient Descent algorithm.
* Weights Initialization: Weights are initialized to { 0.5f, -0.1f, 0.2f }.
* Data Processing: Reads data from data-OR.txt, processes each line, and performs weight updates using the gradient descent approach.
* Gradient Descent Calculation: The TotalOutput function computes the logistic regression output, and the NewWeight function updates the weights.
 
