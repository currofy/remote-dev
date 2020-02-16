![remote-dev](img/undraw_shared_workspace_hwky.png)

[![Gitter](https://badges.gitter.im/currofy/community.svg)](https://gitter.im/currofy/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge) [![Join the chat at https://gitter.im/currofy/remote-dev](https://badges.gitter.im/currofy/remote-dev.svg)](https://gitter.im/currofy/remote-dev?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

# Remote Dev

Virtual Dev Environments over Visual Code for your remote teams

See a more detailed [Spanish version of this guide](README-ES.md).

Remote Dev allow us to share different OS or/and application environments removing the need to install their components in our team's local machines.

It does that by creating Docker containers that include applications, extensions, any config files or source code.

### Main use cases

- **Stand-Alone Dev Sandboxes**
  We might need to isolate our building and runtime enviromnet from our local environment;

Mabye because we want to test on a production like environment
or there might be some conflicts between platforms that stop us working locally,
or to avoid dealing with multiple platform dependent frameworks. Say you develop on Mac or Windows and runtime env is on Linux.

In any case, the point is, _write once, run everywhere_

- **Container based applications**
  If you are developing an application to run on containers you might want to develop directly over a container, closer to live environment

# Quick star guide

## System Requirements

**Local**

- **Windows**. Docker Desktop 2.0 o superior in Windows 10 Pro/Ent. Docker Toolbox no supported.
- **macOS**. Docker Desktop 2.0 o superior.
- **Linux**. Docker CE/EE 18.06 o superior y Docker Compose 1.21 or superior.

**Containers**. x86_64 Debian 8 or superior, Ubuntu 16.04 or superior, CentOS / RHEL 7 or superior, Containers based on Linux Alpine.

## Installation Guide

1. Docker's client

   **Windows / macOS**.

   1. Install [Docker Desktop For Windows/Mac](https://www.docker.com/products/docker-desktop).
   2. Once installed, right click on toolbar and select:
      "Settings / Preferences / Shared Drives / File Sharing". On settings screen choose where you´d like to use Docker.

   **Linux**.

   1. [Follow instructions as described on Docker' site](https://docs.docker.com/install/#supported-platforms). If you use Docker Compose, follow the specefic guide [Compose](https://docs.docker.com/compose/install/)
   2. Once ready, add your user to grupo _docker_ with the following command: _sudo usermod -aG docker \$USER_
   3. Re start your session and log back in to apply the changes.

2. Install [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio Code Insiders](https://code.visualstudio.com/insiders/)

3. Install pack [Remote Development Extension](https://aka.ms/vscode-remote/download/extension)

We'll cover a "full-time development environment" approach, that is, we'll use both, container and content, as a complete developement environment.

## Setting up Docker Remote on VSCode.

Two ways to go around this depending where are your development is at

### Use a Dockerfile

Set up VSCode to use an existing image from DockerHub, Azure Container Register or created by you.

To use your own images or Docker config files you'll need to create, at the application level, a new directory `.devcontainer` and inside it the `devcontainer.json` file.

To star, open the directory where the `Dockerfile´ lives and once opened it, select the option
**Remote-Containers: Add Development Container Configuration Files...** (press F1 to see command options)

[See also](https://github.com/Microsoft/vscode-docs/blob/master/docs/remote/containers.md)

## Want to Contribute?

## Credits & Sponsors
