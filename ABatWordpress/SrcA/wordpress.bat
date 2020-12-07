@echo off
cd C:\host\www
rd /S /Q wordpress
mysql -u root --password=7610JcEs3024 -e "DROP USER `wordpress`@`localhost`;"
mysql -u root --password=7610JcEs3024 -e "DROP DATABASE `wordpress`;"
mysql -u root --password=7610JcEs3024 -e "CREATE USER `wordpress`@`localhost` IDENTIFIED BY '7610JcEs3024';"
mysql -u root --password=7610JcEs3024 -e "GRANT ALL PRIVILEGES ON  * . * TO  `wordpress`@`localhost`;"
mysql -u root --password=7610JcEs3024 -e "CREATE DATABASE `wordpress`;"
7z x wordpress.zip -y