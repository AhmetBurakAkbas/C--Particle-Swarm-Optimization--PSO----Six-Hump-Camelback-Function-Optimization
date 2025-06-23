# Particle Swarm Optimization in C# - Six-Hump Camelback Function

This project is a Windows Forms application developed entirely in C# to implement the Particle Swarm Optimization (PSO) algorithm from scratch, without using any external libraries or AI tools. The project follows object-oriented programming principles and aims to find the minimum of the Six-Hump Camelback function.

## About the Project

- **Goal:** To minimize the classical Six-Hump Camelback function using a custom PSO algorithm.
- **Technology:** C# with Windows Forms Application.
- **Features:** 
  - Self-implemented PSO algorithm.
  - Object-oriented design.
  - User-friendly interface to configure parameters and view results.
  - Dynamic adjustment of PSO parameters like swarm size, iterations, etc.

## Objective Function

The Six-Hump Camelback function is defined as:

\[
f(x_1, x_2) = 4x_1^2 - 2.1x_1^4 + \frac{1}{3}x_1^6 + x_1x_2 - 4x_2^2 + 4x_2^4
\]

The PSO algorithm is used to find the minimum value of this function.

## Project Structure

- **Form Design:** Allows users to input PSO parameters, start the optimization, and display results.
- **PSO Algorithm:** Updates particle positions and velocities while tracking the best solutions.
- **Objective Function:** Calculates the Six-Hump Camelback function value for given inputs.

## How to Run

1. Open the solution in Visual Studio.
2. Build and run the Windows Forms application.
3. Enter PSO parameters such as the number of particles, iterations, etc.
4. Start the optimization process and observe the results.

## Notes

- The project is developed as a unique academic assignment and contains original code.
- Only C# language and standard .NET libraries are used.
- No external libraries or AI tools are incorporated.

---

## Contact

Feel free to reach out if you have any questions or feedback.

---
Ahmet Burak Akbaş
