# Heri CV project

## Introduction

This project was created to show my abilities
Using Best practices.

- Descriptive names
- Atomic Design
- Helper functions
  - Childern as props
- Functional (declarative) programmimg

  - Pure functions
  - Immutability (by Hooks - useState)
  - Side effects are handled by Hooks - UseEffect

- CI/CD
  - project is in GitHub
    - Automatic test
      - Unit Tests (Jest, React Testing Library.)
      - Integration Tests
      - E2E Tests (Cypress )
  - Write tests for components

## Architecture

The project is organized as a monorepo, combining all parts of the application:

- /apps: Contains individual applications:
  - web: Web application (React + Vite).
  - mobile: Mobile application (React Native).
  - backend: Backend server (.NET ASP.NET Core).
- /packages: Shared modules, such as common components and logic.
- [centralized config files]
  All applications share configurations and dependencies through centralized settings in the root directory. This structure simplifies development and project management.

# Development Tools

Project uses yarn package manager.

- use `yarn install` only in the root directory (heri-project) to avoid dependency conflicts.
  - yarn.lock is in the root directory

## Web

React + TypeScript + Vite

### Commands

Start dev server

- root directory - `yarn start:web`
- in project - `yarn dev`

## Mobile

React Native + Expo

## BackEnd
SDKs --> .NET 8
Project technologi --> ASP.NET Core

Start up
1. You have to open backend folder throught IDEA /apps/backend (Not root folder)
2. IDEA will recognize the project structure --> right click on Infrastructure project or Run throught configuration [Infrastructure: http] for development
