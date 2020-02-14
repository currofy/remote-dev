#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["UserBlazor.csproj", ""]
RUN dotnet restore "./UserBlazor.csproj"
COPY . .
WORKDIR "/src/."

# Configure apt
ENV DEBIAN_FRONTEND=noninteractive
RUN apt-get update \
    && apt-get -y install --no-install-recommends apt-utils 2>&1

# Install git, process tools, lsb-release (common in install instructions for CLIs)
# Also dependencies for telepresence
RUN apt-get -y install git procps lsb-release sudo iptables curl

# Install kubectl
RUN curl -LO https://storage.googleapis.com/kubernetes-release/release/$(curl -s https://storage.googleapis.com/kubernetes-release/release/stable.txt)/bin/linux/amd64/kubectl
RUN chmod +x ./kubectl
RUN mv ./kubectl /usr/bin/kubectl

# Install Telepresence
RUN curl -s https://packagecloud.io/install/repositories/datawireio/telepresence/script.deb.sh | bash
RUN apt install -y --no-install-recommends telepresence 

# Copy in kubectl config file and set environment variables
#COPY config /kube/config
ENV KUBECONFIG=/kube/config/config

# Clean up
RUN apt-get autoremove -y \
    && apt-get clean -y \
    && rm -rf /var/lib/apt/lists/*
ENV DEBIAN_FRONTEND=dialog

#ENTRYPOINT ["dotnet", "UserBlazor.dll"]
#ENTRYPOINT [ "dotnet", "UserBlazor.dll", "--urls", "http://0.0.0.0:9001"]