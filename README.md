# HelpDesk

HelpDesk is a C# console application (.NET 8) that centralizes IT/ERP support behind a fast, keyboard-driven menu: info hub, guided database actions (generates ready-to-run SQL statements), applications installer & components, access to drivers & documents, leave-request generator, and OSMR management. 
It is the lightweight predecessor of **PlusConnect** - an internal WinForms (.NET 8) desktop application.

## Why

Reduce context switching and speed up routine support tasks by providing a single, portable entry point for day-to-day operations.

## Features

- **Guided DB actions** – Choose an operation (e.g., change a receipt date by receipt number), enter inputs, and get the exact SQL statement ready to run in your DB client. The app **does not execute SQL**; it only generates it.
- **Applications installer & components** – Quick access to internal installers and required components.
- **Drivers & documents** – One place for frequently used drivers, forms, and documentation.
- **Leave-request generator** – Fast creation of standardized leave/invoire requests.
- **OSMR management** – Shortcut actions for OSMR-related workflows.
- **Fast text UI** – Keyboard-centric menu for speed and clarity.

## PlusConnect (successor)

Internal desktop application developed in C# (WinForms, .NET 8.0). Designed to optimize ERP workflows by automating critical processes (database creation, collection setup, resource management) and simplifying client management across multiple environments. Includes AES-encrypted consultant mode and auto-update system.
