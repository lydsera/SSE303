

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for book_basicinfo
-- ----------------------------
DROP TABLE IF EXISTS `book_basicinfo`;
CREATE TABLE `book_basicinfo`  (
  `ISBN` varchar(18) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `PID` int NOT NULL,
  `BName` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Writer` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Version` int NOT NULL,
  `PubDate` date NOT NULL,
  `Price` int NULL DEFAULT NULL,
  `Intro` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  PRIMARY KEY (`ISBN`) USING BTREE,
  UNIQUE INDEX `uniqueindex_bookbasic_bname`(`BName` ASC) USING BTREE,
  INDEX `FK_Reference_2`(`PID` ASC) USING BTREE,
  INDEX `index_3`(`BName` ASC, `Price` ASC) USING BTREE,
  INDEX `index_bookbasic_bname`(`BName` ASC) USING BTREE,
  INDEX `index1`(`ISBN` ASC, `PID` ASC, `Version` ASC) USING BTREE,
  CONSTRAINT `FK_Reference_2` FOREIGN KEY (`PID`) REFERENCES `press_info` (`pid`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for book_borrow
-- ----------------------------
DROP TABLE IF EXISTS `book_borrow`;
CREATE TABLE `book_borrow`  (
  `BoID` int NOT NULL AUTO_INCREMENT,
  `BID` int NULL DEFAULT NULL,
  `RID` int NULL DEFAULT NULL,
  `MID` int NULL DEFAULT NULL,
  `BoTime` datetime NULL DEFAULT NULL,
  `ShouldReTime` datetime NULL DEFAULT NULL,
  `ReNewTimes` int NULL DEFAULT NULL,
  `isReturn` tinyint NULL DEFAULT 0,
  PRIMARY KEY (`BoID`) USING BTREE,
  INDEX `FK_Reference_4`(`BID` ASC) USING BTREE,
  INDEX `FK_Reference_5`(`RID` ASC) USING BTREE,
  INDEX `FK_Reference_6`(`MID` ASC) USING BTREE,
  CONSTRAINT `FK_Reference_4` FOREIGN KEY (`BID`) REFERENCES `book_info` (`bid`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_Reference_5` FOREIGN KEY (`RID`) REFERENCES `reader_info` (`RID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_Reference_6` FOREIGN KEY (`MID`) REFERENCES `manager_info` (`MID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 15 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for book_info
-- ----------------------------
DROP TABLE IF EXISTS `book_info`;
CREATE TABLE `book_info`  (
  `bid` int NOT NULL AUTO_INCREMENT,
  `ISBN` varchar(18) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `BCondition` tinyint(1) NOT NULL,
  `WareTime` datetime NOT NULL,
  PRIMARY KEY (`bid`) USING BTREE,
  INDEX `FK_Reference_3`(`ISBN` ASC) USING BTREE,
  CONSTRAINT `FK_Reference_3` FOREIGN KEY (`ISBN`) REFERENCES `book_basicinfo` (`ISBN`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 13 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for book_lost
-- ----------------------------
DROP TABLE IF EXISTS `book_lost`;
CREATE TABLE `book_lost`  (
  `LID` int NOT NULL AUTO_INCREMENT,
  `BID` int NOT NULL,
  `RID` int NOT NULL,
  `MID` int NOT NULL,
  `PayBack` int NOT NULL,
  `OperTime` datetime NOT NULL,
  PRIMARY KEY (`LID`) USING BTREE,
  INDEX `FK_Reference_13`(`BID` ASC) USING BTREE,
  INDEX `FK_Reference_14`(`RID` ASC) USING BTREE,
  INDEX `FK_Reference_15`(`MID` ASC) USING BTREE,
  CONSTRAINT `FK_Reference_13` FOREIGN KEY (`BID`) REFERENCES `book_info` (`bid`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_Reference_14` FOREIGN KEY (`RID`) REFERENCES `reader_info` (`RID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_Reference_15` FOREIGN KEY (`MID`) REFERENCES `manager_info` (`MID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for book_return
-- ----------------------------
DROP TABLE IF EXISTS `book_return`;
CREATE TABLE `book_return`  (
  `ReID` int NOT NULL AUTO_INCREMENT,
  `MID` int NOT NULL,
  `BID` int NOT NULL,
  `RID` int NOT NULL,
  `ReTime` datetime NOT NULL,
  PRIMARY KEY (`ReID`) USING BTREE,
  INDEX `FK_Reference_7`(`MID` ASC) USING BTREE,
  INDEX `FK_Reference_8`(`BID` ASC) USING BTREE,
  INDEX `FK_Reference_9`(`RID` ASC) USING BTREE,
  CONSTRAINT `FK_Reference_7` FOREIGN KEY (`MID`) REFERENCES `manager_info` (`MID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_Reference_8` FOREIGN KEY (`BID`) REFERENCES `book_info` (`bid`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_Reference_9` FOREIGN KEY (`RID`) REFERENCES `reader_info` (`RID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 12 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for manager_info
-- ----------------------------
DROP TABLE IF EXISTS `manager_info`;
CREATE TABLE `manager_info`  (
  `MID` int NOT NULL,
  `Account` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `MName` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Sex` bit(1) NOT NULL,
  `Phone` varchar(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Post` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Password` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MID`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for out_fine
-- ----------------------------
DROP TABLE IF EXISTS `out_fine`;
CREATE TABLE `out_fine`  (
  `FID` int NOT NULL AUTO_INCREMENT,
  `BID` int NOT NULL,
  `RID` int NOT NULL,
  `MID` int NOT NULL,
  `FinePrice` int NOT NULL,
  `IsFin` tinyint(1) NOT NULL,
  `FineTime` datetime NULL DEFAULT NULL,
  `Remark` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  PRIMARY KEY (`FID`) USING BTREE,
  INDEX `FK_Reference_10`(`BID` ASC) USING BTREE,
  INDEX `FK_Reference_11`(`RID` ASC) USING BTREE,
  INDEX `FK_Reference_12`(`MID` ASC) USING BTREE,
  CONSTRAINT `FK_Reference_10` FOREIGN KEY (`BID`) REFERENCES `book_info` (`bid`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_Reference_11` FOREIGN KEY (`RID`) REFERENCES `reader_info` (`RID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_Reference_12` FOREIGN KEY (`MID`) REFERENCES `manager_info` (`MID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for press_info
-- ----------------------------
DROP TABLE IF EXISTS `press_info`;
CREATE TABLE `press_info`  (
  `pid` int NOT NULL AUTO_INCREMENT,
  `PName` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Contact` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Phone` varchar(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Address` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`pid`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 7 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for reader_info
-- ----------------------------
DROP TABLE IF EXISTS `reader_info`;
CREATE TABLE `reader_info`  (
  `RID` int NOT NULL AUTO_INCREMENT,
  `RTID` int NOT NULL,
  `RName` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Sex` bit(1) NOT NULL,
  `Phone` varchar(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ReDate` datetime NOT NULL,
  `ValDate` datetime NOT NULL,
  `CurBNum` int NULL DEFAULT NULL,
  `TotBNum` int NULL DEFAULT NULL,
  `IsLost` tinyint(1) NULL DEFAULT NULL,
  `VioNum` int NULL DEFAULT NULL,
  `Remark` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  PRIMARY KEY (`RID`) USING BTREE,
  INDEX `FK_Reference_1`(`RTID` ASC) USING BTREE,
  CONSTRAINT `FK_Reference_1` FOREIGN KEY (`RTID`) REFERENCES `reader_type` (`RTID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 10 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for reader_type
-- ----------------------------
DROP TABLE IF EXISTS `reader_type`;
CREATE TABLE `reader_type`  (
  `RTID` int NOT NULL,
  `RTName` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `BNum` int NOT NULL,
  `BDay` int NOT NULL,
  PRIMARY KEY (`RTID`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
