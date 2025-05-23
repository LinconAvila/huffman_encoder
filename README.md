# 🔐 Huffman Encoder - Huffman Algorithm Compression Project

A web encoder for text compression using the Huffman algorithm, implemented in C# (ASP.NET Core).

![Interface Screenshot](interface_screenshot\interface.png)

## 📚 About the Huffman Algorithm

### Basic Concept
The **Huffman algorithm** is a data compression method that assigns variable-length codes to characters, where:
- More frequent characters receive **shorter** codes.
- Less frequent characters receive **longer** codes.
- Uses a **binary tree** (Huffman Tree) to determine the codes.

### Step-by-Step
1. **Frequency Counting**: Calculates the frequency of each character in the text.
2. **Tree Construction**:
   - Creates leaf nodes for each character.
   - Iteratively combines the two nodes with the lowest frequency into a new parent node.
   - Repeats until a single tree is formed.
3. **Code Generation**:
   - Assigns `0` for left paths and `1` for right paths.
   - Each character’s code is the path from the root to its leaf.

## 🛠 Implementation

### Project Structure
```plaintext
HuffmanWebApp/
├── Controllers/
│   └── HomeController.cs      # HTTP request logic
├── Models/
│   ├── Huffman.cs             # Core algorithm class
│   └── HuffmanNode.cs         # Tree node structure
├── Views/
│   └── Home/
│       └── Index.cshtml       # User interface
└── wwwroot/                   # Static files (CSS/JS)
```

### Key Features

- **User-Friendly Web Interface:** Simple form for text input.
- **Real-Time Encoding:** Displays:
  - Compressed binary text
  - Generated code table
  - Handling of special characters (e.g., spaces as `[ ]`)
- **Efficiency:** Optimized for UTF-8 texts.

### Usage Example

```csharp
// Encoding
var (encoded, codes) = Huffman.Encode("aaaa");
// encoded = "0000"
// codes['a'] = "0"
```

## 🚀 How to Run

**Prerequisites:**

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

**Steps:**

1. Clone the repository:

   ```bash
   git clone https://github.com/LinconAvila/huffman_encoder
   ```

2. Run the project:


   ```bash
    cd huffman_encoder
    dotnet run
   ```
3. Access in your browser: ```http://localhost:xxxx```


### 💻 Author

© 2025 - **Lincon Avila de Souza**