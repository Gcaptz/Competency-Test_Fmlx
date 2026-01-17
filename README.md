<div align="center">

  <img src="https://fmlx.b-cdn.net/wp-content/uploads/2017/11/formulatrix-logo-grey-orange-upper-6.png" width="250" alt="Formulatrix Logo" />

  <h1>Formulatrix Engineering Talent Day</h1>
  <h3>Homework Test 1 - Coding Competency Test</h3>

  <p>
    <b>Role:</b> Software Engineer - Backend<br>
    <b>Candidate:</b> Azka Rabbani Minanda
  </p>

  <p>
    <img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 10" />
    <img src="https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
    <img src="https://img.shields.io/badge/Focus-Backend%20Engineering-0078D4?style=for-the-badge&logo=azuredevops&logoColor=white" alt="Backend" />
  </p>

</div>

<hr />

Welcome to my submission for the **Formulatrix Engineering Talent Day**. This repository contains the solution for the **Coding Competency Test Challenge**, demonstrating scalable and clean code practices using the latest **.NET 10** framework.

## 📋 Assessment Overview

The goal of this project is to solve a series of progressive algorithmic problems (variations of the FizzBuzz problem), evolving from simple procedural logic to a scalable Object-Oriented solution.

### Problem Breakdown
| Question | Description | Approach Taken |
| :--- | :--- | :--- |
| **Q1** | Basic Rules (3, 5) | Adopted **String Concatenation** pattern immediately to handle potential overlapping rules cleanly. |
| **Q2** | Added Rule (7) | Extended the string concatenation logic to include the new divisor, proving the scalability of the initial approach. |
| **Q3** | Complex Rules (3, 4, 5, 7, 9) | Validated the robustness of the concatenation logic against a denser set of rules without needing structural changes. |
| **Q4** | Dynamic Rule Engine | Refactored into a **Class-Based Design**. Implemented a custom `CustomFooBar` class to allow dynamic rule injection, adhering to the **Open/Closed Principle**. |

---

## 🚀 Technologies

* **Framework:** .NET 10
* **Language:** C# 14 (preview/latest features)
* **IDE:** Visual Studio Code

> **Note on .NET 10:** I utilized .NET 10 to leverage the latest performance improvements in the CoreCLR and string manipulation optimizations suitable for high-throughput backend services.

---

## 🛠️ Installation & Execution

Since this project uses **.NET 10**, please ensure you have the appropriate SDK installed.

1.  **Clone the Repository**
    ```bash
    git clone https://github.com/Gcaptz/Competency-Test_Fmlx.git
    cd Competency-Test_Fmlx
    ```

2.  **Restore Dependencies**
    ```bash
    dotnet restore
    ```

3.  **Run the Application**
    ```bash
    dotnet run
    ```

## 🧠 Architectural Highlights

For the final challenge (Question 4), I transitioned from a static imperative approach to an Object-Oriented design.

### Key Features:
* **Dynamic Configuration:** The `CustomFooBar` class is agnostic of specific numbers or strings. It accepts rules via `AddRule(int, string)`.
* **Preserved Order:** A `List<(int, string)>` is used instead of a Dictionary to ensure the output string sequence respects the order of rule insertion (e.g., "foo" must appear before "bar").
* **Performance:** Utilized `StringBuilder` for string composition to minimize memory allocation overhead during concatenation operations.

---

<div align="center">
  <sub>Submitted for Formulatrix Engineering Talent Day - January 2026</sub>
</div>