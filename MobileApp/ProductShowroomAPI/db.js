const fs = require('fs');
const sql = require('mssql');

const config = {
    server: 'ZEROYZ', // Например, 'localhost' или IP-адрес вашего сервера
    database: 'TextileProduction', // Имя базы данных
    options: {
        encrypt: true, // Использовать SSL шифрование
        enableArithAbort: true,
        trustServerCertificate: true, // Доверять самоподписанному сертификату
        cryptoCredentialsDetails: {
            ca: fs.readFileSync('path_to_your_certificate.pem') // Путь к вашему сертификату
        }
    },
    authentication: {
        type: 'default',
        options: {
            userName: 'your_username',
            password: 'your_password'
        }
    }
};

sql.connect(config).catch(err => console.log(err));

module.exports = sql;