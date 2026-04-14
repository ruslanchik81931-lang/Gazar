# Gazar Archiver

## Description
Gazar Archiver is a powerful tool designed to compress and decompress files efficiently. It is aimed at users who require a simple yet effective solution for file archiving.

## Features
- **High Compression Ratio**: Efficient algorithms to reduce file size significantly.
- **Fast Processing**: Optimized for speed to handle large files and batches.
- **User-Friendly Interface**: Easy-to-navigate design for seamless user experience.
- **Cross-Platform**: Works on Windows, Linux, and macOS.

## Installation Instructions
1. **Clone the repository**:
   ```bash
   git clone https://github.com/ruslanchik81931-lang/Gazar.git
   cd Gazar
   ```
2. **Install dependencies**:
   Follow the instructions in the `INSTALL.md` file to set up the required libraries.
3. **Build the project**:
   ```bash
   make build
   ```

## Usage Guide
- To compress files:
  ```bash
  ./gazar compress <file_or_directory>
  ```
- To decompress files:
  ```bash
  ./gazar decompress <archive_file>
  ```

For detailed command options, run:
```bash
./gazar --help
```

## License
This project is licensed under the MIT License.