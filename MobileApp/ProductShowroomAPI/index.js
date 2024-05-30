const express = require('express');
const bodyParser = require('body-parser');
const sql = require('./db');

const app = express();
app.use(bodyParser.json());

app.get('/api/company', async (req, res) => {
    try {
        const result = await sql.query`SELECT * FROM Company`;
        res.json(result.recordset);
    } catch (err) {
        res.status(500).send(err.message);
    }
});

app.get('/api/productcatalog', async (req, res) => {
    try {
        const result = await sql.query`SELECT * FROM ProductCatalog`;
        res.json(result.recordset);
    } catch (err) {
        res.status(500).send(err.message);
    }
});

app.post('/api/productconstructor', async (req, res) => {
    try {
        const { width, height, fabric, edging, fittings, previewImage } = req.body;
        const result = await sql.query`INSERT INTO ProductConstructor (Width, Height, Fabric, Edging, Fittings, PreviewImage) VALUES (${width}, ${height}, ${fabric}, ${edging}, ${fittings}, ${previewImage})`;
        res.status(201).json(result);
    } catch (err) {
        res.status(500).send(err.message);
    }
});

const PORT = process.env.PORT || 1433;
app.listen(PORT, () => console.log(`Server running on port ${PORT}`));
