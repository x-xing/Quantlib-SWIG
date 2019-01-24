/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class _DeltaVolQuote {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected _DeltaVolQuote(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(_DeltaVolQuote obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete__DeltaVolQuote(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public final static class DeltaType {
    public final static _DeltaVolQuote.DeltaType Spot = new _DeltaVolQuote.DeltaType("Spot");
    public final static _DeltaVolQuote.DeltaType Fwd = new _DeltaVolQuote.DeltaType("Fwd");
    public final static _DeltaVolQuote.DeltaType PaSpot = new _DeltaVolQuote.DeltaType("PaSpot");
    public final static _DeltaVolQuote.DeltaType PaFwd = new _DeltaVolQuote.DeltaType("PaFwd");

    public final int swigValue() {
      return swigValue;
    }

    public String toString() {
      return swigName;
    }

    public static DeltaType swigToEnum(int swigValue) {
      if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
        return swigValues[swigValue];
      for (int i = 0; i < swigValues.length; i++)
        if (swigValues[i].swigValue == swigValue)
          return swigValues[i];
      throw new IllegalArgumentException("No enum " + DeltaType.class + " with value " + swigValue);
    }

    private DeltaType(String swigName) {
      this.swigName = swigName;
      this.swigValue = swigNext++;
    }

    private DeltaType(String swigName, int swigValue) {
      this.swigName = swigName;
      this.swigValue = swigValue;
      swigNext = swigValue+1;
    }

    private DeltaType(String swigName, DeltaType swigEnum) {
      this.swigName = swigName;
      this.swigValue = swigEnum.swigValue;
      swigNext = this.swigValue+1;
    }

    private static DeltaType[] swigValues = { Spot, Fwd, PaSpot, PaFwd };
    private static int swigNext = 0;
    private final int swigValue;
    private final String swigName;
  }

  public final static class AtmType {
    public final static _DeltaVolQuote.AtmType AtmNull = new _DeltaVolQuote.AtmType("AtmNull");
    public final static _DeltaVolQuote.AtmType AtmSpot = new _DeltaVolQuote.AtmType("AtmSpot");
    public final static _DeltaVolQuote.AtmType AtmFwd = new _DeltaVolQuote.AtmType("AtmFwd");
    public final static _DeltaVolQuote.AtmType AtmDeltaNeutral = new _DeltaVolQuote.AtmType("AtmDeltaNeutral");
    public final static _DeltaVolQuote.AtmType AtmVegaMax = new _DeltaVolQuote.AtmType("AtmVegaMax");
    public final static _DeltaVolQuote.AtmType AtmGammaMax = new _DeltaVolQuote.AtmType("AtmGammaMax");
    public final static _DeltaVolQuote.AtmType AtmPutCall50 = new _DeltaVolQuote.AtmType("AtmPutCall50");

    public final int swigValue() {
      return swigValue;
    }

    public String toString() {
      return swigName;
    }

    public static AtmType swigToEnum(int swigValue) {
      if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
        return swigValues[swigValue];
      for (int i = 0; i < swigValues.length; i++)
        if (swigValues[i].swigValue == swigValue)
          return swigValues[i];
      throw new IllegalArgumentException("No enum " + AtmType.class + " with value " + swigValue);
    }

    private AtmType(String swigName) {
      this.swigName = swigName;
      this.swigValue = swigNext++;
    }

    private AtmType(String swigName, int swigValue) {
      this.swigName = swigName;
      this.swigValue = swigValue;
      swigNext = swigValue+1;
    }

    private AtmType(String swigName, AtmType swigEnum) {
      this.swigName = swigName;
      this.swigValue = swigEnum.swigValue;
      swigNext = this.swigValue+1;
    }

    private static AtmType[] swigValues = { AtmNull, AtmSpot, AtmFwd, AtmDeltaNeutral, AtmVegaMax, AtmGammaMax, AtmPutCall50 };
    private static int swigNext = 0;
    private final int swigValue;
    private final String swigName;
  }

}
