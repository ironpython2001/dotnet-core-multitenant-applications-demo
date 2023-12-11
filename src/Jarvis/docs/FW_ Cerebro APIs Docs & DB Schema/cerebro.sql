-- Printer Table
CREATE TABLE printers
(
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    address CHAR(20) NOT NULL
);

-- Device_profiles Table
CREATE TABLE device_profiles
(
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    tag VARCHAR(40) NOT NULL,
    details VARCHAR(100) NULL
);

-- Builds Table
CREATE TABLE builds
(
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    -- Application name
    name VARCHAR(100) NOT NULL,
    -- Application package name
    package VARCHAR(100) NOT NULL,
    -- [debug, release, mock]
    type VARCHAR(10) NOT NULL,
    -- Build number code
    version_code INT NOT NULL,
    -- Build name
    version VARCHAR(20) NOT NULL,
    -- File path
    file_path VARCHAR(255) NOT NULL
);

-- Analytics Table
CREATE TABLE analytics
(
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    date DATETIME NOT NULL,
    -- Tab/mobile unique device id
    device_id CHAR(40) NOT NULL,
    -- Tab/mobile user selected tag
    device_tag CHAR(40) NOT NULL,
    -- T/M (tablet/mobile)
    device_type CHAR(1) NOT NULL,
    -- Campus Code
    campus VARCHAR(10) NOT NULL,
    -- Department Code
    dept VARCHAR(10) NOT NULL,
    -- Visit Type Code
    visit VARCHAR(10) NOT NULL,
    -- MR Number
    mrno VARCHAR(20) NOT NULL,
    -- Sppointment ID
    appt_id VARCHAR(20) NOT NULL,
    -- (EARLY, LATE, CHECKIN_SUCCESS, CHECKIN_EARLY, CHECKIN_FAIL, CHECKIN_ALREADY, PAYMENT_PENDING)
    checkin_status VARCHAR(20) NULL,
    -- (PAYMENT_EARLY, PAYMENT_SUCCESS, PAYMENT_FAIL)
    payment_status VARCHAR(20) NULL,
    -- UPI, Card, Net Banking etc.
    payment_type VARCHAR(20) NULL,
    -- Payment amount
    amount float NULL,
    -- Application version
    app_version VARCHAR(20) NOT NULL,
    -- (optional) some note or remark like failure reason
    note VARCHAR(255) NULL
);
