
# Microsoft Calculator Project 📱

## Overview 🌟
The Microsoft Calculator Project is an open-source project aimed at providing a powerful and user-friendly calculator application with a wide range of modes, including a newly implemented **Optics Mode**. This mode allows users to calculate optical properties using the basic lens and mirror formulas. The application is structured to provide clear user input fields and display results in an intuitive manner.

## Features 🚀
- **Basic Calculator** ➗: Standard calculator functionality.
- **Programmer Mode** 💻: For binary, octal, decimal, and hexadecimal calculations.
- **Optics Mode** 🔬: Calculate focal length (f), object distance (u), and image distance (v) in mirrors and lenses.

## Optics Mode 🔍

The newly introduced **Optics Mode** allows users to calculate one of the three optical properties:

- **f (focal length)** 🌈
- **v (image distance)** 🖼️
- **u (object distance)** 📏

### How to Use 📝

1. **Input Fields:** 
   - Users can enter any two of the three values: `f`, `v`, and `u`. 
   - Based on the inputs, the third value is automatically calculated and displayed. 🧮

2. **Select Mirror or Lens:** 
   - There is a toggle above the numpad that allows users to select either a **Mirror** or **Lens** for the calculation. 🔄

3. **Type of Mirror/Lens:** 
   - **Mirror Options:** 
     - **Plane Mirror** 🪞
     - **Concave Mirror** 🔵
     - **Convex Mirror** 🔴
   - **Lens Options:** 
     - **Concave Lens** 🔽
     - **Convex Lens** 🔼

4. **Calculation Logic:** 
   - For mirrors and lenses, the respective optical formula is used to calculate the missing value. 
   - The user inputs two values, and the third value is derived accordingly. 💡

### Mirror Formula:
For mirrors, the formula used is:
\[ rac{1}{f} = rac{1}{v} + rac{1}{u} \]

### Lens Formula:
For lenses, the formula used is:
\[ rac{1}{f} = rac{1}{v} - rac{1}{u} \]

### Example Use Cases:
- **Plane Mirror** 🪞: Always provides the same image distance as the object distance (v = u).
- **Concave Mirror** 🔵: Can produce real or virtual images depending on the object distance.
- **Convex Mirror** 🔴: Always produces a virtual image behind the mirror.
- **Concave Lens** 🔽: Produces a virtual image.
- **Convex Lens** 🔼: Can produce real or virtual images depending on the object distance.

### Screenshots 📸
(Include relevant screenshots here, if necessary)

## Installation 🛠️

1. Clone the repository:
   ```bash
   git clone https://github.com/AK01177/Microsoft-Calc-Project.git
   ```

2. Navigate to the project folder:
   ```bash
   cd Microsoft-Calc-Project
   ```

3. Open the project in your preferred development environment.

4. Run the application. 🚀

## Contributing 🤝
We welcome contributions to the project. If you'd like to contribute, please fork the repository, make your changes, and submit a pull request. Be sure to follow the coding standards and best practices used in the project.

## License 📜
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
