-- Tabela equipment_model: Modelos de Equipamento
CREATE TABLE equipment_model (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(255) NOT NULL
);

-- Inserir dados na tabela equipment_model
INSERT INTO equipment_model (name) VALUES
('Modelo A'),
('Modelo B'),
('Modelo C'),
('Modelo D'),
('Modelo E');

-- Tabela equipment_state: Estados de Equipamento
CREATE TABLE equipment_state (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    color VARCHAR(7) NOT NULL -- Armazenar cores em formato hexadecimal (#FFFFFF)
);

-- Inserir dados na tabela equipment_state
INSERT INTO equipment_state (name, color) VALUES
('Operando', '#00FF00'),
('Parado', '#FF0000'),
('Em Manutenção', '#FFFF00'),
('Aguardando Peças', '#FFA500'),
('Em Teste', '#0000FF');

-- Tabela equipment: Equipamentos
CREATE TABLE equipment (
    id INT IDENTITY(1,1) PRIMARY KEY,
    equipment_model_id INT FOREIGN KEY REFERENCES equipment_model(id) ON DELETE CASCADE,
    name VARCHAR(255) NOT NULL
);

-- Inserir dados na tabela equipment
INSERT INTO equipment (equipment_model_id, name) VALUES
(1, 'Equipamento 1'),
(1, 'Equipamento 2'),
(2, 'Equipamento 3'),
(3, 'Equipamento 4'),
(4, 'Equipamento 5'),
(5, 'Equipamento 6');

-- Tabela equipment_model_state_hourly_earnings: Valor por hora dos estados para cada modelo de equipamento
CREATE TABLE equipment_model_state_hourly_earnings (
    equipment_model_id INT FOREIGN KEY REFERENCES equipment_model(id) ON DELETE CASCADE,
    equipment_state_id INT FOREIGN KEY REFERENCES equipment_state(id) ON DELETE CASCADE,
    value DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY (equipment_model_id, equipment_state_id)
);

-- Inserir dados na tabela equipment_model_state_hourly_earnings
INSERT INTO equipment_model_state_hourly_earnings (equipment_model_id, equipment_state_id, value) VALUES
(1, 1, 100.00),
(1, 2, 50.00),
(2, 1, 80.00),
(2, 3, 70.00),
(3, 1, 120.00),
(3, 4, 90.00),
(4, 1, 110.00),
(4, 2, 60.00),
(5, 3, 95.00),
(5, 5, 75.00);

-- Tabela equipment_state_history: Histórico de estados dos equipamentos
CREATE TABLE equipment_state_history (
    equipment_id INT FOREIGN KEY REFERENCES equipment(id) ON DELETE CASCADE,
    date DATETIME NOT NULL,
    equipment_state_id INT FOREIGN KEY REFERENCES equipment_state(id) ON DELETE CASCADE,
    PRIMARY KEY (equipment_id, date)
);

-- Inserir dados na tabela equipment_state_history
INSERT INTO equipment_state_history (equipment_id, date, equipment_state_id) VALUES
(1, '2024-09-01 10:00:00', 1),
(1, '2024-09-01 12:00:00', 2),
(2, '2024-09-01 09:00:00', 3),
(2, '2024-09-02 10:00:00', 1),
(3, '2024-09-01 11:00:00', 4),
(4, '2024-09-01 13:00:00', 5),
(5, '2024-09-01 14:00:00', 2),
(6, '2024-09-01 15:00:00', 1);

-- Tabela equipment_position_history: Histórico de posições dos equipamentos
CREATE TABLE equipment_position_history (
    equipment_id INT FOREIGN KEY REFERENCES equipment(id) ON DELETE CASCADE,
    date DATETIME NOT NULL,
    lat DECIMAL(10, 8) NOT NULL, -- Latitude com precisão de até 8 casas decimais
    lon DECIMAL(11, 8) NOT NULL, -- Longitude com precisão de até 8 casas decimais
    PRIMARY KEY (equipment_id, date)
);

-- Inserir dados na tabela equipment_position_history
INSERT INTO equipment_position_history (equipment_id, date, lat, lon) VALUES
(1, '2024-09-01 10:00:00', -23.550520, -46.633308),
(1, '2024-09-01 12:00:00', -23.551520, -46.634308),
(2, '2024-09-01 09:00:00', -23.552520, -46.635308),
(3, '2024-09-01 11:30:00', -23.553520, -46.636308),
(4, '2024-09-01 14:15:00', -23.554520, -46.637308),
(5, '2024-09-01 16:00:00', -23.555520, -46.638308),
(6, '2024-09-01 17:45:00', -23.556520, -46.639308);
