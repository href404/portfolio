#!/bin/bash

git pull
dotnet publish --configuration Release
sudo systemctl restart portfolio.service
