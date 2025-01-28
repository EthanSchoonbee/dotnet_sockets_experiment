# 🔌 dotnet_sockets

> A modern TCP socket communication experiment built with .NET 8 🚀

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square&logo=.net)](https://dotnet.microsoft.com/download)
[![License](https://img.shields.io/badge/license-MIT-blue?style=flat-square)](LICENSE)

## 🧔🏻 Author
- Ethan Schoonbee

<div style="display: flex; align-items: center;">
  <div align="center">
    <img src="https://github.com/user-attachments/assets/d4118767-1bbc-46f0-af72-de206052503f" alt="whitespace_logo" width="150" height="150">
    </div>
    <div align="center">
    <img src="https://github.com/user-attachments/assets/c3d3b90b-87e0-4844-8657-4e27164b6c59" alt="whitespace_logo" width="200" height="20">
  </div>
</div>

## 🎯 Overview

`dotnet_sockets_experiment` is an experimental project showcasing TCP socket communication in C#. Through two console applications, it demonstrates the fundamentals of network programming using .NET 8:

- **tcp_server**: A TCP server listening for connections and sending messages
- **tcp_client**: A TCP client receiving and displaying messages

## 🏗️ Project Structure

### 1. tcp_server
- Listens on `127.0.0.1:8888`
- Handles incoming connections
- Sends welcome message to connected clients

### 2. tcp_client
- Connects to server at `127.0.0.1:8888`
- Receives and displays server messages
- Gracefully handles connection lifecycle

## ⚙️ Prerequisites

Make sure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) (or later)
- A compatible IDE such as:
  - [JetBrains Rider](https://www.jetbrains.com/rider/)
  - [Visual Studio Code](https://code.visualstudio.com/)
  - Visual Studio 2022

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/EthanSchoonbee/dotnet_sockets_experiment/
cd dotnet_sockets
```

### 2. Run the Server

```bash
cd tcp_server
dotnet run
```

### 3. Run the Client

Open a new terminal and run:

```bash
cd tcp_client
dotnet run
```

## 📚 Learning Outcomes

This project demonstrates several key concepts in network programming:

- TCP server/client architecture implementation
- Network stream management in C#
- Data conversion for network transmission
- Usage of `TcpClient` and `TcpListener` classes
- Basic socket programming patterns

## 🔍 Technical Details

The project explores:

- Socket communication in .NET 8
- Network stream handling
- Byte array ↔ string conversions
- TCP connection management

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

<div align="center">
Made with ❤️ using .NET 8
</div>
